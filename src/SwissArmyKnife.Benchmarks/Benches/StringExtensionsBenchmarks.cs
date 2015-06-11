﻿using Minibench.Framework;

namespace SwissArmyKnife.Benchmarks.Benches
{
    internal class StringExtensionsBenchmarks
    {
        [Benchmark]
        public void FormatStringWithOneArg()
        {
            var s = "Test: {0}".FormatThis("1");
        }

        [Benchmark]
        public void FormatStringWithTwoArgs()
        {
            var s = "Test: {0} {1}".FormatThis("1", "2");
        }

        [Benchmark]
        public void FormatStringWithThreeArgs()
        {
            var s = "Test: {0} {1} {2}".FormatThis("1", "2", "3");
        }

        [Benchmark]
        public void FormatStringWithManyArgs()
        {
            var s = "Test: {0} {1} {2} {3} {4} {5}".FormatThis("1", "2", "3", "4", "5", "6");
        }

        [Benchmark]
        public void FormatStringWithToManyArgs()
        {
            var s = "Test: {0} {1} {2} {3} {4}".FormatThis("1", "2", "3", "4", "5", "6");
        }

        [Benchmark]
        public void FormatStringWithOneArgFormattedTwice()
        {
            var s = "Test: {0} {0}".FormatThis("1");
        }

        #region Types

        [Benchmark]
        public void FormatStringWithIntegerAsArg()
        {
            var s = "Test: {0}".FormatThis(1);
        }

        [Benchmark]
        public void FormatStringWithDoubleAsArg()
        {
            var s = "Test: {0}".FormatThis(1.1);
        }

        #endregion Types
    }
}
