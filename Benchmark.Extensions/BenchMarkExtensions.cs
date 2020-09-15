using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using CallCenter.Extensions;
using System;

namespace Benchmark.Extensions
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [HtmlExporter]
    [CsvExporter]
    [RPlotExporter]
    [MemoryDiagnoser]
    [RankColumn]
    public class BenchMarkExtensions
    {
        [Params(1000000)]
        public int N;

        [Benchmark(Description = "Esse método é o original")]
        public string Original() => DateTime.Now.GenerateProtocolOriginal();

        [Benchmark(Description = "Esse método é o v1")]
        public string V1() => DateTime.Now.GenerateProtocolV1();

        [Benchmark(Description = "Esse método é o v2")]
        public string V2() => DateTime.Now.GenerateProtocolV2();

        [Benchmark(Description = "Esse método é o v3")]
        public string V3() => DateTime.Now.GenerateProtocolV3();

        [Benchmark(Description = "Esse método é o lastest")]
        public string Lastest() => DateTime.Now.GenerateProtocolLastest();
    }
}
