using NUnit.Framework;
using System;
using System.IO;

namespace SwissArmyKnife.Tests.Extensions
{
    [TestFixture]
    internal class StreamExtensionTests
    {
        [Test]
        public void Reset_Successful()
        {
            var s = GetStream();

            s.Reset();
        }

        [Test]
        public void ResetDisposedStream()
        {
            var s = GetStream();
            s.Dispose();

            Assert.Throws<ObjectDisposedException>(() => s.Reset());
        }

        [Test]
        public void ResetClosedStream()
        {
            var s = GetStream();
            s.Close();

            Assert.Throws<ObjectDisposedException>(() => s.Reset());
        }

        private static Stream GetStream()
        {
            const int size = 65535;

            var newStream = new MemoryStream();

            var data = new byte[size];

            Random r = new Random();
            r.NextBytes(data);

            newStream.Write(data, 0, size);

            return newStream;
        }
    }
}
