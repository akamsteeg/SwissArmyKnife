using System;
using BenchmarkDotNet.Attributes;

namespace SwissArmyKnife.Benchmarks.Benches.Extensions
{
    public class StringExtensionsBenchmarks
    {
        #region FormatWith()

        [Benchmark]
        public void FormatStringWithOneArg()
        {
            var s = "Test: {0}".FormatWith("1");
        }

        [Benchmark]
        public void FormatStringWithTwoArgs()
        {
            var s = "Test: {0} {1}".FormatWith("1", "2");
        }

        [Benchmark]
        public void FormatStringWithThreeArgs()
        {
            var s = "Test: {0} {1} {2}".FormatWith("1", "2", "3");
        }

        [Benchmark]
        public void FormatStringWithManyArgs()
        {
            var s = "Test: {0} {1} {2} {3} {4} {5}".FormatWith("1", "2", "3", "4", "5", "6");
        }

        [Benchmark]
        public void FormatStringWithToManyArgs()
        {
            var s = "Test: {0} {1} {2} {3} {4}".FormatWith("1", "2", "3", "4", "5", "6");
        }

        [Benchmark]
        public void FormatStringWithOneArgFormattedTwice()
        {
            var s = "Test: {0} {0}".FormatWith("1");
        }

        #region Types

        [Benchmark]
        public void FormatStringWithIntegerAsArg()
        {
            var s = "Test: {0}".FormatWith(1);
        }

        [Benchmark]
        public void FormatStringWithDoubleAsArg()
        {
            var s = "Test: {0}".FormatWith(1.1);
        }

        #endregion Types

        #endregion FormatWith()

        #region Truncate()

        [Benchmark]
        public void Truncate()
        {
            var truncatedText = "Lorem ipsum".Truncate(5);
        }

        [Benchmark]
        public void TruncateWithSuffix()
        {
            var truncatedText = "Lorem ipsum".Truncate(5, "...");
        }

        #endregion

        #region IsNullOrEmpty()

        [Benchmark]
        public void IsNullOrEmptyWithNullString()
        {
            string s = null;

            var result = s.IsNullOrEmpty();
        }

        [Benchmark]
        public void IsNullOrEmptyWithEmptyString()
        {
            string s = string.Empty;

            var result = s.IsNullOrEmpty();
        }

        [Benchmark]
        public void IsNullOrEmptyWithString()
        {
            var s = "Lorem ipsum";

            var result = s.IsNullOrEmpty();
        }

        #endregion

        #region IsNullOrWhiteSpace()

        [Benchmark]
        public void IsNullOrWhiteSpaceWithNullString()
        {
            string s = null;

            var result = s.IsNullOrWhiteSpace();
        }

        [Benchmark]
        public void IsNullOrWhiteSpaceWithEmptyString()
        {
            string s = string.Empty;

            var result = s.IsNullOrWhiteSpace();
        }

        [Benchmark]
        public void IsNullOrWhiteSpaceWithString()
        {
            var s = "Lorem ipsum";

            var result = s.IsNullOrWhiteSpace();
        }

        #endregion

        #region Contains()

        [Benchmark]
        public void ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparison()
        {
            var s = "Lorem Ipsum";

            var result = s.Contains("ipsum", StringComparison.InvariantCultureIgnoreCase);
        }

        [Benchmark]
        public void ContainsWithValidCorrectCasedStringAndCaseSensensitiveComparison()
        {
            var s = "Lorem Ipsum";

            var result = s.Contains("Ipsum", StringComparison.InvariantCulture);
        }

        [Benchmark]
        public void ContainsWithValidIncorrectCasedStringAndCaseSensensitiveComparison()
        {
            var s = "Lorem Ipsum";

            var result = s.Contains("ipsum", StringComparison.InvariantCulture);
        }
        #endregion
    }
}
