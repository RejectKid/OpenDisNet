using BenchmarkDotNet.Running;
using OpenDisNet.Benchmarks;

BenchmarkSwitcher.FromAssembly(typeof(SignalPduCodecBenchmarks).Assembly).Run(args);
