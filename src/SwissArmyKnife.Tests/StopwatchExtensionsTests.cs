using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests
{
    [TestFixture]
    public class StopwatchExtensionsTests
    {
        [Test]
        public void GetValueAndReset_Successful()
        {
            var sw = Stopwatch.StartNew();

            Thread.Sleep(500);
            var elapsed = sw.GetValueAndReset();

            Assert.NotNull(elapsed);
            Assert.Greater(elapsed.TotalMilliseconds, 250);

            Assert.Less(500, sw.Elapsed.TotalMilliseconds);
        }
    }
}
