using Minibench.Framework;
using SwissArmyKnife.Extensions;
using System.Text;

namespace SwissArmyKnife.Benchmarks.Benches.Extensions
{
    internal class StringBuilderExtensionsBenchmarks
    {
        [Benchmark]
        public void AppendFormattedLineOneArg()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0}", "0");
        }

        [Benchmark]
        public void AppendFormattedLineTwoArgs()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1}", "0", "1");
        }

        [Benchmark]
        public void AppendFormattedLineThreeArgs()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2}", "0", "1", "2");
        }

        [Benchmark]
        public void AppendFormattedLineManyArgs()
        {
            var sb = new StringBuilder();
            sb.AppendFormatLine("Test: {0} {1} {2} {3} {4}", "0", "1", "2", "3", "4");
        }
    }
}
