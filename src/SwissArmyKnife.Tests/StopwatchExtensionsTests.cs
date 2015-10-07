using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace SwissArmyKnife.Tests.Extensions
{
    [TestFixture]
    public class StopwatchExtensionsTests
    {
        [Test]
        public void GetElapsedAndRestart_Successful()
        {
            var sw = Stopwatch.StartNew();

            Thread.Sleep(500);
            var elapsed = sw.GetElapsedAndRestart();

            Assert.NotNull(elapsed);
            Assert.Greater(elapsed.TotalMilliseconds, 250);

            Assert.Less(sw.Elapsed.TotalMilliseconds, 500);
        }
    }
}
