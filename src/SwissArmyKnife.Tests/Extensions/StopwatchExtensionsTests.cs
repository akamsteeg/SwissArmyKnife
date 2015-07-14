using NUnit.Framework;
using SwissArmyKnife.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
