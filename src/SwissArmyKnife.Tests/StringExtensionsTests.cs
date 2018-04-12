using System;
using NUnit.Framework;
using System.Threading;
using System.Globalization;

namespace SwissArmyKnife.Tests.Extensions
{
    [TestFixture]
    class StringExtensionsTests
    {
        #region FormatWith()

        [Test]
        public void FormatStringWithOneArg_Successful()
        {
            var s = "Test: {0}".FormatWith("1");

            Assert.AreEqual("Test: 1", s);
        }

        [Test]
        public void FormatStringWithTwoArgs_Successful()
        {
            var s = "Test: {0} {1}".FormatWith("1", "2");

            Assert.AreEqual("Test: 1 2", s);
        }

        [Test]
        public void FormatStringWithThreeArgs_Successful()
        {
            var s = "Test: {0} {1} {2}".FormatWith("1", "2", "3");

            Assert.AreEqual("Test: 1 2 3", s);
        }

        [Test]
        public void FormatStringWithFourArgs_Successful()
        {
            var s = "Test: {0} {1} {2} {3}".FormatWith("1", "2", "3", "4");

            Assert.AreEqual("Test: 1 2 3 4", s);
        }

        [Test]
        public void FormatStringWithManyArgs_Successful()
        {
            var s = "Test: {0} {1} {2} {3} {4} {5}".FormatWith("1", "2", "3", "4", "5", "6");

            Assert.AreEqual("Test: 1 2 3 4 5 6", s);
        }

        [Test]
        public void FormatStringWithToManyArgs_Successful()
        {
            var s = "Test: {0} {1} {2} {3} {4}".FormatWith("1", "2", "3", "4", "5", "6");

            Assert.AreEqual("Test: 1 2 3 4 5", s);
        }

        [Test]
        public void FormatStringWithNotEnoughArgs_Throws()
        {
            Assert.Throws<FormatException>(() =>
                {
                    var s = "Test: {0} {1} {2} {3} {4} {5}".FormatWith("1", "2", "3", "4", "5");
                });
        }

        [Test]
        public void FormatStringWithOneArgFormattedTwice_Successful()
        {
            var s = "Test: {0} {0}".FormatWith("1");

            Assert.AreEqual("Test: 1 1", s);
        }


        #region Types

        [Test]
        public void FormatStringWithIntegerAsArg_Successful()
        {
            var s = "Test: {0}".FormatWith(1);

            Assert.AreEqual("Test: 1", s);
        }

        [Test]
        public void FormatStringWithDoubleAsArg_Successful()
        {
#if NETCOREAPP1_1
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
#else
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Ensure a dot in the string representation of a double
#endif

            var s = "Test: {0}".FormatWith(1.1);

            Assert.AreEqual("Test: 1.1", s);
        }

#endregion

#endregion

#region Truncate()

        [Test]
        public void TruncateString_Successful()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(5);

            Assert.IsNotNull(truncatedText);
            Assert.AreEqual("Lorem", truncatedText);
        }

        [Test]
        public void TruncateStringWithLengthBeyondSourceStringLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(int.MaxValue));
        }

        [Test]
        public void TruncateStringToZeroLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(0));
        }

        [Test]
        public void TruncateStringToNegativeLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(-1));
        }

        [Test]
        public void TruncateStringWithSuffix_Successful()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(5, "...");

            Assert.IsNotNull(truncatedText);
            Assert.AreEqual("Lorem...", truncatedText);
        }


        [Test]
        public void TruncateStringToZeroLengthWithSuffix_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(0, "..."));
        }

        [Test]
        public void TruncateStringToNegativeLengthWithSuffix_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(-1, "..."));
        }

        [Test]
        public void TruncateStringWithSuffixAndLengthBeyondSourceStringLength_Throws()
        {
            const string text = "Lorem ipsum";

            Assert.Throws<ArgumentOutOfRangeException>(() => text.Truncate(int.MaxValue, "..."));
        }

#endregion

#region IsNullOrEmpty()

        [Test]
        public void IsNullOrEmptyOnEmptyStringReturnsTrue()
        {
            var s = string.Empty;

            Assert.IsTrue(s.IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrEmptyOnNullStringReturnsTrue()
        {
            string s = null;

            Assert.IsTrue(s.IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrEmptyOnNotEmptyStringReturnsFalse()
        {
            string s = "Lorem Ipsum";

            Assert.IsFalse(s.IsNullOrEmpty());
        }

#endregion

#region IsNullOrWhiteSpace()

        [Test]
        public void IsNullOrWhiteSpaceOnEmptyStringReturnsTrue()
        {
            var s = string.Empty;

            Assert.IsTrue(s.IsNullOrWhiteSpace());
        }

        [Test]
        public void IsNullOrWhiteSpaceOnNullStringReturnsTrue()
        {
            string s = null;

            Assert.IsTrue(s.IsNullOrWhiteSpace());
        }

        [Test]
        public void IsNullOrWhiteSpaceOnWhiteSpaceStringReturnsTrue()
        {
            var s = " ";

            Assert.IsTrue(s.IsNullOrWhiteSpace());
        }

        [Test]
        public void IsNullOrWhiteSpaceOnNotEmptyStringReturnsFalse()
        {
            string s = "Lorem Ipsum";

            Assert.IsFalse(s.IsNullOrWhiteSpace());
        }

#endregion

#region Contains()

        [Test]
        public void ContainsWithEmptyStringReturnsTrue()
        {
            string s = "Lorem Ipsum";

            Assert.IsTrue(s.Contains("", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void ContainsWithNullStringThrows()
        {
            string s = "Lorem Ipsum";

            Assert.Throws<ArgumentNullException>(() => s.Contains(null, StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void ContainsWithValidCorrectCasedStringAndCaseInsensitiveReturnsTrue()
        {
            string s = "Lorem Ipsum";

            Assert.IsTrue(s.Contains("Ipsum", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void ContainsWithValidIncorrectCasedStringAndCaseInsensitiveComparisonReturnsTrue()
        {
            string s = "Lorem Ipsum";

            Assert.IsTrue(s.Contains("ipsum", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void ContainsWithValidIncorrectCasedStringAndCaseSensitiveComparisonReturnsFalse()
        {
            string s = "Lorem Ipsum";

            Assert.IsFalse(s.Contains("ipsum", StringComparison.Ordinal));
        }
#endregion
    }
}
