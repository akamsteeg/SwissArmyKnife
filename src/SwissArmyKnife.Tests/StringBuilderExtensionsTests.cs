using System;
using System.Text;
using Xunit;

namespace SwissArmyKnife.Tests.Extensions
{
    public class StringBuilderExtensionsTests
    {
        [Fact]
        public void AppendFormattedLineOneArg_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0}", "0");

            var expected = string.Format("Test: 0{0}", Environment.NewLine);
            Assert.Equal(expected, sb.ToString());
        }

        [Fact]
        public void AppendFormattedLineTwoArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1}", "0", "1");

            var expected = string.Format("Test: 0 1{0}", Environment.NewLine);
            Assert.Equal(expected, sb.ToString());
        }

        [Fact]
        public void AppendFormattedLineThreeArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2}", "0", "1", "2");

            var expected = string.Format("Test: 0 1 2{0}", Environment.NewLine);
            Assert.Equal(expected, sb.ToString());
        }

        [Fact]
        public void AppendFormattedLineFourArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2} {3}", "0", "1", "2", "3");

            var expected = string.Format("Test: 0 1 2 3{0}", Environment.NewLine);
            Assert.Equal(expected, sb.ToString());
        }

        [Fact]
        public void AppendFormattedLineManyArgs_Successful()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2} {3} {4}", "0", "1", "2", "3", "4");

            var expected = string.Format("Test: 0 1 2 3 4{0}", Environment.NewLine);
            Assert.Equal(expected, sb.ToString());
        }

    }
}
