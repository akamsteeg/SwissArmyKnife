using System;
using Xunit;
using System.Threading;
using System.Globalization;

namespace SwissArmyKnife.Tests.Extensions
{
    public class StringExtensionsTests
    {
        #region FormatWith()

        [Fact]
        public void FormatStringWithOneArg_Successful()
        {
            var s = "Test: {0}".FormatWith("1");

            Assert.Equal("Test: 1", s);
        }

        [Fact]
        public void FormatStringWithTwoArgs_Successful()
        {
            var s = "Test: {0} {1}".FormatWith("1", "2");

            Assert.Equal("Test: 1 2", s);
        }

        [Fact]
        public void FormatStringWithThreeArgs_Successful()
        {
            var s = "Test: {0} {1} {2}".FormatWith("1", "2", "3");

            Assert.Equal("Test: 1 2 3", s);
        }

        [Fact]
        public void FormatStringWithFourArgs_Successful()
        {
            var s = "Test: {0} {1} {2} {3}".FormatWith("1", "2", "3", "4");

            Assert.Equal("Test: 1 2 3 4", s);
        }

        [Fact]
        public void FormatStringWithManyArgs_Successful()
        {
            var s = "Test: {0} {1} {2} {3} {4} {5}".FormatWith("1", "2", "3", "4", "5", "6");

            Assert.Equal("Test: 1 2 3 4 5 6", s);
        }

        [Fact]
        public void FormatStringWithToManyArgs_Successful()
        {
            var s = "Test: {0} {1} {2} {3} {4}".FormatWith("1", "2", "3", "4", "5", "6");

            Assert.Equal("Test: 1 2 3 4 5", s);
        }

        [Fact]
        public void FormatStringWithNotEnoughArgs_Throws()
        {
            Assert.Throws<FormatException>(() =>
                {
                    var s = "Test: {0} {1} {2} {3} {4} {5}".FormatWith("1", "2", "3", "4", "5");
                });
        }

        [Fact]
        public void FormatStringWithOneArgFormattedTwice_Successful()
        {
            var s = "Test: {0} {0}".FormatWith("1");

            Assert.Equal("Test: 1 1", s);
        }


        #region Types

        [Fact]
        public void FormatStringWithIntegerAsArg_Successful()
        {
            var s = "Test: {0}".FormatWith(1);

            Assert.Equal("Test: 1", s);
        }

        [Fact]
        public void FormatStringWithDoubleAsArg_Successful()
        {
#if NETCOREAPP1_1
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
#else
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Ensure a dot in the string representation of a double
#endif

            var s = "Test: {0}".FormatWith(1.1);

            Assert.Equal("Test: 1.1", s);
        }

#endregion

#endregion

#region Truncate()

        [Fact]
        public void TruncateString_Successful()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(5);

            Assert.NotNull(truncatedText);
            Assert.Equal("Lorem", truncatedText);
        }

        [Fact]
        public void TruncateStringWithLengthBeyondSourceStringLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(int.MaxValue));
        }

        [Fact]
        public void TruncateStringToZeroLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(0));
        }

        [Fact]
        public void TruncateStringToNegativeLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(-1));
        }

        [Fact]
        public void TruncateStringWithSuffix_Successful()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(5, "...");

            Assert.NotNull(truncatedText);
            Assert.Equal("Lorem...", truncatedText);
        }


        [Fact]
        public void TruncateStringToZeroLengthWithSuffix_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(0, "..."));
        }

        [Fact]
        public void TruncateStringToNegativeLengthWithSuffix_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(-1, "..."));
        }

        [Fact]
        public void TruncateStringWithSuffixAndLengthBeyondSourceStringLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(int.MaxValue, "..."));
        }

#endregion

#region IsNullOrEmpty()

        [Fact]
        public void IsNullOrEmptyOnEmptyStringReturnsTrue()
        {
            var s = string.Empty;

            Assert.True(s.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmptyOnNullStringReturnsTrue()
        {
            string s = null;

            Assert.True(s.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmptyOnNotEmptyStringReturnsFalse()
        {
            string s = "Lorem Ipsum";

            Assert.False(s.IsNullOrEmpty());
        }

#endregion

#region IsNullOrWhiteSpace()

        [Fact]
        public void IsNullOrWhiteSpaceOnEmptyStringReturnsTrue()
        {
            var s = string.Empty;

            Assert.True(s.IsNullOrWhiteSpace());
        }

        [Fact]
        public void IsNullOrWhiteSpaceOnNullStringReturnsTrue()
        {
            string s = null;

            Assert.True(s.IsNullOrWhiteSpace());
        }

        [Fact]
        public void IsNullOrWhiteSpaceOnWhiteSpaceStringReturnsTrue()
        {
            var s = " ";

            Assert.True(s.IsNullOrWhiteSpace());
        }

        [Fact]
        public void IsNullOrWhiteSpaceOnNotEmptyStringReturnsFalse()
        {
            string s = "Lorem Ipsum";

            Assert.False(s.IsNullOrWhiteSpace());
        }

#endregion

#region Contains()

        [Fact]
        public void ContainsWithEmptyStringReturnsTrue()
        {
            string s = "Lorem Ipsum";

            Assert.True(s.Contains("", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ContainsWithNullStringThrows()
        {
            string s = "Lorem Ipsum";

            Assert.Throws<ArgumentNullException>(() => s.Contains(null, StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ContainsWithValidCorrectCasedStringAndCaseInsensitiveReturnsTrue()
        {
            string s = "Lorem Ipsum";

            Assert.True(s.Contains("Ipsum", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparisonReturnsTrue()
        {
            string s = "Lorem Ipsum";

            Assert.True(s.Contains("ipsum", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ContainsWithValidIncorrectCasedStringAndCaseSensitiveComparisonReturnsFalse()
        {
            string s = "Lorem Ipsum";

            Assert.False(s.Contains("ipsum", StringComparison.Ordinal));
        }
#endregion
    }
}
