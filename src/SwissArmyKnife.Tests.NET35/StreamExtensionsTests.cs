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
        private const int SIZE = 1024;

        private Stream SourceStream
        {
            get; set;
        }

        [SetUp]
        public void SetUp()
        {
            this.SourceStream = new MemoryStream();

            var data = new byte[SIZE];

            Random r = new Random();
            r.NextBytes(data);

            this.SourceStream.Write(data, 0, SIZE);

            this.SourceStream.Seek(0, SeekOrigin.Begin);
        }

        [Test]
        public void CopyToEmptyStream_Sucessful()
        {
            MemoryStream destination = new MemoryStream();

            this.SourceStream.CopyTo(destination);

            Assert.IsNotNull(destination);
            Assert.AreEqual(SIZE, destination.Length);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CopyToNullStream_Throws()
        {
            MemoryStream destination = null;

            this.SourceStream.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyToDisposedStream_Throws()
        {
            MemoryStream destination = new MemoryStream();
            destination.Dispose();

            this.SourceStream.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyToClosedStream_Throws()
        {
            MemoryStream destination = new MemoryStream();
            destination.Close();

            this.SourceStream.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyFromDisposedStream_Throws()
        {
            MemoryStream destination = new MemoryStream();

            this.SourceStream.Dispose();

            this.SourceStream.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void CopyFromClosedStream_Throws()
        {
            MemoryStream destination = new MemoryStream();
            
            this.SourceStream.Close();

            this.SourceStream.CopyTo(destination);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CopyToWithZeroBufferSize_Throws()
        {
            MemoryStream destination = new MemoryStream();

            this.SourceStream.CopyTo(destination, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CopyToWithNegativeBufferSize_Throws()
        {
            MemoryStream destination = new MemoryStream();

            this.SourceStream.CopyTo(destination, -1);
        }
    }
}
