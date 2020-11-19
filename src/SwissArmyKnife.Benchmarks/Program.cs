using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using SwissArmyKnife.Benchmarks.Benches.Extensions;
using System;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Toolchains.CsProj;

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

            config
              .AddDiagnoser(MemoryDiagnoser.Default);

            config.AddJob(
              Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp31).AsBaseline(),
              Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp21),
              Job.Default.WithToolchain(CsProjClassicNetToolchain.Net48)
              );

            return config;
        }
    }
}
