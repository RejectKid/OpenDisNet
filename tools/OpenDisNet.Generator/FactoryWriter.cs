using System.Text;

namespace OpenDisNet.Generator;

internal static class FactoryWriter
{
    public static string Create(DisSchema schema)
    {
        var text = new StringBuilder();
        text.AppendLine("// Factory for the 72 standardized DIS v7 PDU types.");
        text.AppendLine("using OpenDisNet.Protocol;");
        text.AppendLine();
        text.AppendLine("namespace OpenDisNet.Pdus;");
        text.AppendLine();
        text.AppendLine("public static class PduFactory");
        text.AppendLine("{");
        text.AppendLine("    public static Pdu Create(PduType pduType, byte exerciseId = 0)");
        text.AppendLine("    {");
        text.AppendLine("        Pdu pdu = (byte)pduType switch");
        text.AppendLine("        {");
        foreach (PduDefinition pdu in schema.Pdus)
            text.AppendLine($"            {pdu.Type} => new {pdu.Name}(),");
        text.AppendLine("            _ => throw new ArgumentOutOfRangeException(nameof(pduType), pduType, \"DIS v7 defines PDU types 1 through 72.\"),");
        text.AppendLine("        };");
        text.AppendLine();
        text.AppendLine("        pdu.ProtocolVersion = 7;");
        text.AppendLine("        pdu.ExerciseId = exerciseId;");
        text.AppendLine("        pdu.PduType = (byte)pduType;");
        text.AppendLine("        pdu.ProtocolFamily = ProtocolFamilyFor((byte)pduType);");
        text.AppendLine("        if (pdu is PduBase body)");
        text.AppendLine("            body.PduStatus = new PduStatus();");
        text.AppendLine("        return pdu;");
        text.AppendLine("    }");
        text.AppendLine();
        text.AppendLine("    private static byte ProtocolFamilyFor(byte pduType) => pduType switch");
        text.AppendLine("    {");
        foreach (IGrouping<byte, PduDefinition> group in schema.Pdus.GroupBy(x => Family(x.SourceFile)).OrderBy(x => x.Key))
        {
            string cases = string.Join(" or ", group.Select(x => x.Type));
            text.AppendLine($"        {cases} => {group.Key},");
        }
        text.AppendLine("        _ => 0,");
        text.AppendLine("    };");
        text.AppendLine("}");
        return text.ToString().ReplaceLineEndings("\n");
    }

    private static byte Family(string sourceFile) => sourceFile switch
    {
        "EntityInformationFamilyPdus.xml" => 1,
        "WarfareFamilyPdus.xml" => 2,
        "LogisticsFamilyPdus.xml" => 3,
        "RadioCommunicationsFamilyPdus.xml" => 4,
        "SimulationManagementFamilyPdus.xml" => 5,
        "DistributedEmissionsFamilyPdus.xml" => 6,
        "EntityManagementFamilyPdus.xml" => 7,
        "MinefieldFamilyPdus.xml" => 8,
        "SyntheticEnvironmentFamilyPdus.xml" => 9,
        "SimulationManagementWithReliabilityFamilyPdus.xml" => 10,
        "LiveEntityFamilyPdus.xml" => 11,
        "InformationOperationsFamilyPdus.xml" => 13,
        _ => throw new InvalidDataException($"No protocol-family mapping for '{sourceFile}'."),
    };
}
