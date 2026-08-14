using SharpFuzz;

if (args is ["--smoke"])
{
    ParserFuzzTarget.RunSmokeCorpus();
    return;
}

if (args is ["--write-corpus", string directory])
{
    ParserFuzzTarget.WriteCorpus(directory);
    return;
}

Fuzzer.OutOfProcess.Run(stream =>
{
    using var input = new MemoryStream();
    stream.CopyTo(input);
    ParserFuzzTarget.Run(input.ToArray());
});
