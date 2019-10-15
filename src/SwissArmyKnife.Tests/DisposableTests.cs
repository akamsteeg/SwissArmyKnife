using System;
using Xunit;

namespace SwissArmyKnife.Tests
{
    public class DisposableTests
    {
        [Fact]
        public void Dispose_Successful()
        {
            var t = new DisposableObject();
            Assert.False(t.ObjectIsDisposed);

            t.Dispose();
            Assert.True(t.ObjectIsDisposed);
        }

        [Fact]
        public void Using_Successful()
        {
            DisposableObject t;
            using (t = new DisposableObject())
            {
                Assert.False(t.ObjectIsDisposed);
            }

            Assert.True(t.ObjectIsDisposed);
        }

        [Fact]
        public void DoubleDisposeDoesNotThrow_Successful()
        {
            var t = new DisposableObject();
            Assert.False(t.ObjectIsDisposed);

            t.Dispose();
            t.Dispose();

            Assert.True(t.ObjectIsDisposed);
        }

        [Fact]
        public void ThrowIfDisposedBeforeDispose_Successful()
        {
            var t = new DisposableObject();
            Assert.False(t.ObjectIsDisposed);

            t.ThrowWhenDisposed();

            t.Dispose();

            Assert.True(t.ObjectIsDisposed);
            Assert.Throws<ObjectDisposedException>(() => t.ThrowWhenDisposed());
        }
    }

    internal sealed class DisposableObject : Disposable
    {
        public bool ObjectIsDisposed
        {
            get;
            private set;
        }

        protected override void Dispose(bool disposing)
        {
            this.ObjectIsDisposed = true;
        }

        public void ThrowWhenDisposed()
        {
            this.ThrowIfDisposed();
        }
    }

}
