using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using SwissArmyKnife.Benchmarks.Benches.Extensions;
using System;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;

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
            };

            return result;
        }

        private static IConfig GetConfig()
        {
            var config = ManualConfig.Create(DefaultConfig.Instance);

            config.Add(MemoryDiagnoser.Default);

            config.Add(Job.Default.With(CoreRuntime.Core30));
            config.Add(Job.Default.With(ClrRuntime.Net472));

            return config;
        }
    }
}
