using Minibench.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Benchmarks.Benches
{
    internal class GenericExtensionsBenchmarks
    {
        #region IsAnyOf()

        [Benchmark]
        public void StringIsAnyOfSingleValue()
        {
            var t1 = "test".IsAnyOf("test");
        }

        [Benchmark]
        public void StringIsAnyOfTwoValues()
        {
            var t1 = "test".IsAnyOf("test", "fake0");
        }

        [Benchmark]
        public void StringIsAnyOfThreeValues()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1");
        }

        [Benchmark]
        public void StringIsAnyOfFourValues()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1", "fake2");
        }

        [Benchmark]
        public void StringIsAnyOfManyValues()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1", "fake2", "fake3");
        }

        [Benchmark]
        public void StringIsAnyOfManyValuesFails()
        {
            var t1 = "test".IsAnyOf("fake", "fake0", "fake1", "fake2", "fake3");
        }

        [Benchmark]
        public void IntIsAnyOfSingleValue()
        {
            var t1 = 1.IsAnyOf(1);
        }

        [Benchmark]
        public void IntIsAnyOfTwoValues()
        {
            var t1 = 1.IsAnyOf(1, 2);
        }

        [Benchmark]
        public void IntIsAnyOfThreeValues()
        {
            var t1 = 1.IsAnyOf(1, 2, 3);
        }

        [Benchmark]
        public void IntIsAnyOfFourValues()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4);
        }

        [Benchmark]
        public void IntIsAnyOfManyValues()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4, 5);
        }

        [Benchmark]
        public void IntIsAnyOfTwoValuesFails()
        {
            var t1 = 0.IsAnyOf(1, 2, 3, 4, 5);
        }

        #endregion
    }
}
