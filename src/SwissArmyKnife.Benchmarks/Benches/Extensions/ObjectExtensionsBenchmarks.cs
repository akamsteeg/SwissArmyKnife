using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace SwissArmyKnife.Benchmarks.Benches.Extensions
{
    public class ObjectExtensionsBenchmarks
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
        public void IntIsAnyOfManyValuesFails()
        {
            var t1 = 0.IsAnyOf(1, 2, 3, 4, 5);
        }

        [Benchmark]
        public void IntIsAnyOfManyValuesArray()
        {
            var t1 = 1.IsAnyOf(new int[] { 1, 2, 3, 4, 5 });
        }

        [Benchmark]
        public void IntIsAnyOfManyValuesArrayFails()
        {
            var t1 = 0.IsAnyOf(new int[] { 1, 2, 3, 4, 5 });
        }

        [Benchmark]
        public void IntIsAnyOfManyValuesIEnumerable()
        {
            var t1 = 1.IsAnyOf(new List<int>() { 1, 2, 3, 4, 5 });
        }

        [Benchmark]
        public void IntIsAnyOfManyValuesIEnumerableFails()
        {
            var t1 = 0.IsAnyOf(new List<int>() { 1, 2, 3, 4, 5 });
        }

        #endregion

        #region IsEqualToAll()

        [Benchmark]
        public void StringIsEqualToAllSingleValue()
        {
            var t1 = "test".IsEqualToAll("test");
        }

        [Benchmark]
        public void StringIsEqualToAllTwoValues()
        {
            var t1 = "test".IsEqualToAll("test", "test");
        }

        [Benchmark]
        public void StringIsEqualToAllThreeValues()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test");
        }

        [Benchmark]
        public void StringIsEqualToAllourValues()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test", "test");
        }

        [Benchmark]
        public void StringIsEqualToAllManyValues()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test", "test", "test");
        }

        [Benchmark]
        public void StringIsEqualToAllManyValuesFails()
        {
            var t1 = "test".IsEqualToAll("test", "test", "test", "test", "test");
        }

        [Benchmark]
        public void IntIsEqualToAllSingleValue()
        {
            var t1 = 1.IsEqualToAll(1);
        }

        [Benchmark]
        public void IntIsEqualToAllTwoValues()
        {
            var t1 = 1.IsEqualToAll(1, 1);
        }

        [Benchmark]
        public void IntIsEqualToAllThreeValues()
        {
            var t1 = 1.IsEqualToAll(1, 1, 1);
        }

        [Benchmark]
        public void IntIsEqualToAllourValues()
        {
            var t1 = 1.IsEqualToAll(1, 1, 1, 1);
        }

        [Benchmark]
        public void IntIsEqualToAllManyValues()
        {
            var t1 = 1.IsEqualToAll(1, 1, 1, 1);
        }

        [Benchmark]
        public void IntIsEqualToAllManyValuesFails()
        {
            var t1 = 0.IsEqualToAll(1, 1, 1, 2);
        }

        [Benchmark]
        public void IntIsEqualToAllManyValuesArray()
        {
            var t1 = 1.IsEqualToAll(new int[] { 1, 1, 1, 2 });
        }

        [Benchmark]
        public void IntIsEqualToAllManyValuesIEnumerable()
        {
            var t1 = 1.IsEqualToAll(new List<int>() { 1, 1, 1, 1 });
        }

        [Benchmark]
        public void IntIsEqualToAllManyValuesIEnumerableFails()
        {
            var t1 = 0.IsEqualToAll(new List<int>() { 11, 1, 1, 2 });
        }

        #endregion
    }
}
