using System;
using NUnit.Framework;
using System.Threading;
using System.Globalization;

namespace SwissArmyKnife.Tests.Extensions
{
    [TestFixture]
    class StringExtensionsTests
    {
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
        [ExpectedException(typeof(FormatException))]
        public void FormatStringWithNotEnoughArgs_Throws()
        {
            var s = "Test: {0} {1} {2} {3} {4} {5}".FormatWith("1", "2", "3", "4", "5");
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
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Ensure a dot in the string representation of a double

            var s = "Test: {0}".FormatWith(1.1);

            Assert.AreEqual("Test: 1.1", s);
        }

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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TruncateStringWithLengthBeyondSourceStringLength_Throws()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(int.MaxValue);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TruncateStringToZeroLength_Throws()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TruncateStringToNegativeLength_Throws()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(-1);
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TruncateStringToZeroLengthWithSuffix_Throws()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(0, "...");
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TruncateStringToNegativeLengthWithSuffix_Throws()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(-1, "...");
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TruncateStringWithSuffixAndLengthBeyondSourceStringLength_Throws()
        {
            const string text = "Lorem ipsum";

            var truncatedText = text.Truncate(int.MaxValue, "...");
        }

        #endregion
    }
}
