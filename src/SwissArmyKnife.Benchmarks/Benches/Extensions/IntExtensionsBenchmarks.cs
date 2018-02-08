using BenchmarkDotNet.Attributes;

namespace SwissArmyKnife.Benchmarks.Benches.Extensions
{
    public class IntExtensionsBenchmarks
    {
        [Benchmark]
        public void MilliSeconds_Succesfull()
        {
            var result = 1000.MilliSeconds();
        }

        [Benchmark]
        public void Seconds_Succesfull()
        {
            var result = 10.Seconds();
        }

        [Benchmark]
        public void Minutes_Succesfull()
        {
            var result = 60.Minutes();
        }

        [Benchmark]
        public void Hours_Succesfull()
        {
            var result = 1.Hours();
        }

        [Benchmark]
        public void Days_Succesfull()
        {
            var result = 1.Days();
        }
    }
}
