using NUnit.Framework;
using SwissArmyKnife.Extensions;
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
        [ExpectedException(typeof(ObjectDisposedException))]
        public void ResetDisposedStream()
        {
            var s = GetStream();
            s.Dispose();

            s.Reset();
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void ResetClosedStream()
        {
            var s = GetStream();
            s.Close();

            s.Reset();
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
