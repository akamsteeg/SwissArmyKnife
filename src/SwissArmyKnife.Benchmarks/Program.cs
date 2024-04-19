using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Validators;
using System.Reflection;

namespace SwissArmyKnife.Benchmarks
{
    class Program
    {
        private static void Main(string[] args)
        {
            var config = GetConfig();
            BenchmarkSwitcher
              .FromAssembly(Assembly.GetExecutingAssembly())
              .Run(args, config);
        }

        private static IConfig GetConfig()
        {
            var config = ManualConfig.Create(DefaultConfig.Instance);

            config
              .AddDiagnoser(MemoryDiagnoser.Default);

            config.AddJob(
              Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp80).AsBaseline(),
              Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp60)
              );

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                config.AddJob(Job.Default.WithToolchain(CsProjClassicNetToolchain.Net481));
            }

            config.SummaryStyle = SummaryStyle.Default
              .WithRatioStyle(RatioStyle.Percentage);

            config.AddValidator(JitOptimizationsValidator.FailOnError); // Fail when any of the referenced assemblies are not optimized

            config.WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest));

            return config;
        }
    }
}
