using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwissArmyKnife;
using System.IO;

namespace SwissArmyKnife.Tests.NET35
{
    [TestFixture]
    internal class StreamExtensionsTests
    {
        [Test]
        public void CopyToEmptyStream_Sucessful()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();

            source.CopyTo(destination);

            Assert.IsNotNull(destination);
            Assert.AreEqual(source.Length, destination.Length);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CopyToNullStream_Throws()
        {
            var source = GetStream();
            MemoryStream destination = null;

            source.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyToDisposedStream_Throws()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();
            destination.Dispose();

            source.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyToClosedStream_Throws()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();
            destination.Close();

            source.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyFromDisposedStream_Throws()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();

            source.Dispose();

            source.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyFromClosedStream_Throws()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();
            
            source.Close();

            source.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CopyToWithZeroBufferSize_Throws()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();

            source.CopyTo(destination, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CopyToWithNegativeBufferSize_Throws()
        {
            var source = GetStream();
            MemoryStream destination = new MemoryStream();

            source.CopyTo(destination, -1);
        }

        private static Stream GetStream()
        {
            const int size = 65535;

            var newStream = new MemoryStream();

            var data = new byte[size];

            Random r = new Random();
            r.NextBytes(data);

            newStream.Write(data, 0, size);
            newStream.Reset();

            return newStream;
        }
    }
}
