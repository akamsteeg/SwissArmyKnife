using Xunit;
using System;
using System.IO;

namespace SwissArmyKnife.Tests.Extensions
{
    public class StreamExtensionTests
    {
        [Fact]
        public void Reset_Successful()
        {
            var s = GetStream();

            s.Reset();
            Assert.Equal(0, s.Position);
        }

        [Fact]
        public void ResetDisposedStream()
        {
            var s = GetStream();
            s.Dispose();

            Assert.Throws<ObjectDisposedException>(() => s.Reset());
        }

        [Fact]
        public void ResetClosedStream()
        {
            var s = GetStream();
            s.Dispose();

            Assert.Throws<ObjectDisposedException>(() => s.Reset());
        }

        private static Stream GetStream()
        {
            const int size = 65535;

            var newStream = new MemoryStream();

            var data = new byte[size];

            var r = new Random();
            r.NextBytes(data);

            newStream.Write(data, 0, size);

            return newStream;
        }
    }
}
