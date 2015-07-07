using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissArmyKnife;
using NUnit.Framework;
using SwissArmyKnife.Extensions;

namespace SwissArmyKnife.Tests
{
    [TestFixture]
    class StringBuilderExtensionsTests
    {
        [Test]
        public void AppendFormattedLineOneArg_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0}", "0");

            var expected = string.Format("Test: 0{0}", Environment.NewLine);
            Assert.AreEqual(expected, sb.ToString());
        }

        [Test]
        public void AppendFormattedLineTwoArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1}", "0", "1");

            var expected = string.Format("Test: 0 1{0}", Environment.NewLine);
            Assert.AreEqual(expected, sb.ToString());
        }

        [Test]
        public void AppendFormattedLineThreeArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2}", "0", "1", "2");

            var expected = string.Format("Test: 0 1 2{0}", Environment.NewLine);
            Assert.AreEqual(expected, sb.ToString());
        }

        [Test]
        public void AppendFormattedLineManyArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2} {3} {4}", "0", "1", "2", "3", "4");

            var expected = string.Format("Test: 0 1 2 3 4{0}", Environment.NewLine);
            Assert.AreEqual(expected, sb.ToString());
        }

    }
}
