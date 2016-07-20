using BenchmarkDotNet.Attributes;
using SwissArmyKnife.DataStructures;
using System.Text;

namespace SwissArmyKnife.Benchmarks.Benches.DataStructures
{
    public class BloomFilterBenchmarks
    {
        private BloomFilter BloomFilter
        {
            get;
            set;
        }

        private byte[] TestData
        {
            get;
            set;
        }

        public BloomFilterBenchmarks()
        {
            this.BloomFilter = new BloomFilter(128);
            this.TestData = Encoding.UTF8.GetBytes("lorem ipsum dolor sit amet");
        }

        [Benchmark]
        public void Add()
        {
            this.BloomFilter.Add(this.TestData);
        }

        [Benchmark]
        public void Test()
        {
            var result = this.BloomFilter.Test(this.TestData);
        }
    }
}
