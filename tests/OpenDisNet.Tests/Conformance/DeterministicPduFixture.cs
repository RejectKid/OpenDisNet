using System.Collections;
using System.Reflection;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

internal static class DeterministicPduFixture
{
    private static readonly HashSet<string> NeverPopulate =
    [
        nameof(Pdu.ProtocolVersion),
        nameof(Pdu.PduType),
        nameof(Pdu.ProtocolFamily),
        nameof(Pdu.Length),
        nameof(Pdu.Header),
        "PduStatus",
        "Padding",
        "Radio",
        "DataBitLength",
        "RecordLength",
    ];

    public static Pdu Create(PduType type)
    {
        Pdu pdu = PduFactory.Create(type, exerciseId: 7);
        pdu.Timestamp = 0x01020304;
        Populate(pdu, new HashSet<object>(ReferenceEqualityComparer.Instance), depth: 0);
        ApplyPduRules(pdu);
        return pdu;
    }

    private static void Populate(object instance, HashSet<object> visited, int depth)
    {
        if (depth > 12 || !visited.Add(instance)) return;

        foreach (PropertyInfo property in instance.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            if (!property.CanRead || !property.CanWrite || property.GetIndexParameters().Length != 0) continue;
            if (NeverPopulate.Contains(property.Name) || property.Name.Contains("Padding", StringComparison.OrdinalIgnoreCase)
                || property.Name.StartsWith("Pad", StringComparison.OrdinalIgnoreCase)) continue;

            Type type = property.PropertyType;
            object? current = property.GetValue(instance);

            if (type.IsArray)
            {
                Type elementType = type.GetElementType()!;
                int length = current is Array existing && existing.Length != 0 ? existing.Length : 1;
                Array values = Array.CreateInstance(elementType, length);
                for (int index = 0; index < length; index++)
                    values.SetValue(CreateValue(elementType, depth + 1, index + 1, visited), index);
                property.SetValue(instance, values);
                continue;
            }

            if (current is IList list && type.IsGenericType)
            {
                Type elementType = type.GetGenericArguments()[0];
                list.Clear();
                list.Add(CreateValue(elementType, depth + 1, 1, visited));
                continue;
            }

            if (IsScalar(type))
            {
                property.SetValue(instance, CreateScalar(type, property.Name));
                continue;
            }

            if (type.IsValueType)
            {
                property.SetValue(instance, CreateValue(type, depth + 1, 1, visited));
                continue;
            }

            object child = current ?? Activator.CreateInstance(type)
                ?? throw new InvalidOperationException($"Cannot create fixture value for {type}.");
            property.SetValue(instance, child);
            Populate(child, visited, depth + 1);
        }
    }

    private static object CreateValue(Type type, int depth, int ordinal, HashSet<object> visited)
    {
        if (IsScalar(type)) return CreateScalar(type, string.Empty, ordinal);
        if (type.IsValueType)
        {
            ConstructorInfo? constructor = type.GetConstructors().SingleOrDefault(x => x.GetParameters().Length == 1);
            if (constructor is not null)
            {
                Type parameterType = constructor.GetParameters()[0].ParameterType;
                return constructor.Invoke([CreateScalar(parameterType, string.Empty, ordinal)]);
            }
            return Activator.CreateInstance(type)!;
        }

        object value = Activator.CreateInstance(type)
            ?? throw new InvalidOperationException($"Cannot create fixture value for {type}.");
        Populate(value, visited, depth);
        return value;
    }

    private static bool IsScalar(Type type) => type.IsEnum || type == typeof(byte) || type == typeof(sbyte)
        || type == typeof(ushort) || type == typeof(short) || type == typeof(uint) || type == typeof(int)
        || type == typeof(ulong) || type == typeof(long) || type == typeof(float) || type == typeof(double);

    private static object CreateScalar(Type type, string propertyName, int ordinal = 1)
    {
        if (type.IsEnum)
        {
            Array values = Enum.GetValues(type);
            return values.Cast<object>().FirstOrDefault(x => Convert.ToUInt64(x) != 0) ?? values.GetValue(0)!;
        }

        int value = propertyName.Contains("Count", StringComparison.OrdinalIgnoreCase)
            || propertyName.StartsWith("NumberOf", StringComparison.OrdinalIgnoreCase) ? 1 : ordinal + 1;
        if (type == typeof(byte)) return checked((byte)value);
        if (type == typeof(sbyte)) return checked((sbyte)value);
        if (type == typeof(ushort)) return checked((ushort)value);
        if (type == typeof(short)) return checked((short)value);
        if (type == typeof(uint)) return checked((uint)value);
        if (type == typeof(int)) return value;
        if (type == typeof(ulong)) return checked((ulong)value);
        if (type == typeof(long)) return checked((long)value);
        if (type == typeof(float)) return value + 0.25f;
        if (type == typeof(double)) return value + 0.5d;
        throw new InvalidOperationException($"Unsupported scalar fixture type {type}.");
    }

    private static void ApplyPduRules(Pdu pdu)
    {
        switch (pdu)
        {
            case SignalPdu signal:
                signal.SetData([0xA5, 0xC0], meaningfulBitLength: 10);
                signal.SampleCount = 2;
                break;
            case IntercomSignalPdu intercom:
                intercom.Data = [0xA5, 0xC0];
                intercom.DataBitLength = 10;
                intercom.SampleCount = 2;
                break;
            case InformationOperationsActionPdu action:
                action.IoRecords = [CreateIoEffectRecord()];
                break;
            case InformationOperationsReportPdu report:
                report.IoRecords = [CreateIoCommsNodeRecord()];
                break;
            case IdentificationFriendOrFoePdu iff:
                iff.IFFPduLayer3InterrogatorFormatData = null;
                iff.IFFPduLayer4InterrogatorFormatData = null;
                break;
        }
    }

    private static IOEffectRecord CreateIoEffectRecord()
    {
        var value = new IOEffectRecord();
        Populate(value, new HashSet<object>(ReferenceEqualityComparer.Instance), depth: 0);
        value.RecordType = OpenDisNet.Enumerations.VariableRecordType.IoEffect;
        return value;
    }

    private static IOCommsNodeRecord CreateIoCommsNodeRecord()
    {
        var value = new IOCommsNodeRecord();
        Populate(value, new HashSet<object>(ReferenceEqualityComparer.Instance), depth: 0);
        value.RecordType = OpenDisNet.Enumerations.VariableRecordType.IoCommunicationsNode;
        return value;
    }
}
