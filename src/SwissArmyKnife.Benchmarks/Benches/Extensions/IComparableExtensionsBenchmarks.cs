using BenchmarkDotNet.Attributes;

namespace SwissArmyKnife.Benchmarks.Benches.Extensions
{
    public class IComparableExtensionsBenchmarks
    {
        #region IsBetween()

        [Benchmark]
        public void StringIsBetween()
        {
            var t1 = "b".IsBetween("a", "b");
        }

        [Benchmark]
        public void IntIsBetween()
        {
            var t1 = 1.IsBetween(0, 2);
        }

        [Benchmark]
        public void DoubleIsBetween()
        {
            var t1 = 1.0.IsBetween(0.0, 1.1);
        }

        #endregion
    }
}
