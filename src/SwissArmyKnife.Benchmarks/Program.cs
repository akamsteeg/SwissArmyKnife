using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using SwissArmyKnife.Benchmarks.Benches.DataStructures;
using SwissArmyKnife.Benchmarks.Benches.Extensions;
using System;
using BenchmarkDotNet.Diagnosers;

namespace SwissArmyKnife.Benchmarks
{
    class Program
    {
        private static void Main(string[] args)
        {
            var config = GetConfig();
            var benchmarks = GetBenchmarks();

            for (var i = 0; i < benchmarks.Length; i++)
            {
                var typeToRun = benchmarks[i];
                BenchmarkRunner.Run(typeToRun, config);
            }

            //BenchmarkRunner.Run<StringExtensionsBenchmarks>(config);
        }

        private static Type[] GetBenchmarks()
        {
            var result = new Type[]
            {
                // Extensions
                typeof(ObjectExtensionsBenchmarks),
                typeof(IComparableExtensionsBenchmarks),
                typeof(StringBuilderExtensionsBenchmarks),
                typeof(StringExtensionsBenchmarks),
                typeof(IntExtensionsBenchmarks),
                //Data structures
                typeof(BloomFilterBenchmarks),
            };

            return result;
        }

        private static IConfig GetConfig()
        {
            var config = ManualConfig.Create(DefaultConfig.Instance);

            config.Add(MemoryDiagnoser.Default);

            config.Add(Job.Core);
            config.Add(Job.Clr);

            return config;
        }
    }
}
