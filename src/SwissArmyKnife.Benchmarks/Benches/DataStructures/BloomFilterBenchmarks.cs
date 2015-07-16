using Minibench.Framework;
using SwissArmyKnife.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Benchmarks.Benches.DataStructures
{
    internal class BloomFilterBenchmarks
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
