using Xunit;
using System.Diagnostics;
using System.Threading;

namespace SwissArmyKnife.Tests.Extensions
{
    public class StopwatchExtensionsTests
    {
        [Fact]
        public void GetElapsedAndRestart_Successful()
        {
            var sw = Stopwatch.StartNew();

            Thread.Sleep(500);
            var elapsed = sw.GetElapsedAndRestart();

            Assert.True(elapsed.TotalMilliseconds > 250);
            Assert.True(sw.Elapsed.TotalMilliseconds < 500);
        }
    }
}
