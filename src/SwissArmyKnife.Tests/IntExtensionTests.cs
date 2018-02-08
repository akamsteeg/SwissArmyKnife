using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwissArmyKnife.Tests
{
    [TestFixture]
    public class IntExtensionTests
    {
        [Test]
        public void MilliSeconds_Succesfull()
        {
            var result = 1000.MilliSeconds();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TotalSeconds);
        }

        [Test]
        public void Seconds_Succesfull()
        {
            var result = 10.Seconds();

            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.TotalSeconds);
        }

        [Test]
        public void Minutes_Succesfull()
        {
            var result = 60.Minutes();

            Assert.IsNotNull(result);
            Assert.AreEqual(3600, result.TotalSeconds);
        }

        [Test]
        public void Hours_Succesfull()
        {
            var result = 1.Hours();

            Assert.IsNotNull(result);
            Assert.AreEqual(3600, result.TotalSeconds);
        }

        [Test]
        public void Days_Succesfull()
        {
            var result = 1.Days();

            Assert.IsNotNull(result);
            Assert.AreEqual(86400, result.TotalSeconds);
        }
    }
}
