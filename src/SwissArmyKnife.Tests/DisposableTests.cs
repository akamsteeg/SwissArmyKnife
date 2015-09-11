using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests
{
    [TestFixture]
    internal class DisposableTests
    {
        [Test]
        public void Dispose_Successful()
        {
            var t = new DisposableObject();
            Assert.IsFalse(t.ObjectIsDisposed);

            t.Dispose();
            Assert.IsTrue(t.ObjectIsDisposed);
        }

        [Test]
        public void Using_Successful()
        {
            DisposableObject t;
            using (t = new DisposableObject())
            {
                Assert.IsFalse(t.ObjectIsDisposed);
            }

            Assert.IsTrue(t.ObjectIsDisposed);
        }

        [Test]
        public void DoubleDisposeDoesNotThrow_Successful()
        {
            var t = new DisposableObject();
            Assert.IsFalse(t.ObjectIsDisposed);

            t.Dispose();
            t.Dispose();

            Assert.IsTrue(t.ObjectIsDisposed);
        }

        [Test]
        public void ThrowIfDisposedBeforeDispose_Successful()
        {
            var t = new DisposableObject();
            Assert.IsFalse(t.ObjectIsDisposed);

            Assert.DoesNotThrow(() => t.ThrowWhenDisposed());

            t.Dispose();

            Assert.IsTrue(t.ObjectIsDisposed);
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
