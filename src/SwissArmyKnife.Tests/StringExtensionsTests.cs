using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissArmyKnife;
using NUnit.Framework;
using System.Threading;
using System.Globalization;

namespace SwissArmyKnife.Tests
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
    }
}
