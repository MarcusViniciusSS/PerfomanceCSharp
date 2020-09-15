using BenchmarkDotNet.Running;
using System;

namespace Benchmark.Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchMarkExtensions>();

            Console.ReadLine();
        }
    }
}
