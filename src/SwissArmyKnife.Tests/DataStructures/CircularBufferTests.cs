using System;
using NUnit.Framework;
using SwissArmyKnife.DataStructures.CircularBuffer;

namespace SwissArmyKnife.Tests.DataStructures
{
    [TestFixture]
    public class CircularBufferTests
    {
        [Test]
        public void Ctor_WithSize0_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CircularBuffer<int>(0));
        }

        [Test]
        public void Ctor_WithSize10_Succeeds()
        {
            const int size = 10;

            var buffer = new CircularBuffer<int>(size);

            Assert.AreEqual(size, buffer.Size);
        }

        [Test]
        public void Add_SingleItem_SetsCountToOne()
        {
            var buffer = Create();

            buffer.Add(1);

            Assert.AreEqual(1, buffer.Count);
        }

        [Test]
        public void Add_FillToSize_SetsCountToSize()
        {
            var buffer = Create();

            for (var i = 0; i < buffer.Size; i++)
            {
                buffer.Add(i);
            }

            Assert.AreEqual(buffer.Size, buffer.Count);
        }

        [Test]
        public void Add_FillToSizeTwice_SetsCountToSize()
        {
            var buffer = Create();

            for (var i = 0; i < buffer.Size * 2; i++)
            {
                buffer.Add(i);
            }

            Assert.AreEqual(buffer.Size, buffer.Count);
        }

        [Test]
        public void Add_SingleItemAndGetSingleItem_Succeeds()
        {
            var buffer = Create();

            buffer.Add(1);
            var result = buffer.Get();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Add_SizeTwiceItemsAndGet_Succeeds()
        {
            var buffer = Create();

            var numberOfItems = buffer.Size * 1.5;

            for (var i = 0; i < numberOfItems; i++)
            {
                buffer.Add(i);
            }

            Assert.AreEqual(buffer.Size, buffer.Count);

            for (var i = numberOfItems - 1; i > 0; i--)
            {
                var result = buffer.Get();

                Assert.AreEqual(i, result);
            }
        }

        [Test]
        public void Add_SingleItemAndGet10Items_Succeeds()
        {
            var buffer = Create();

            const int size = 10;

            for (var i = 0; i < size; i++)
            {
                buffer.Add(i);
            }

            Assert.AreEqual(size, buffer.Count);

            for (var i = size - 1; i > 0; i--)
            {
                var result = buffer.Get();

                Assert.AreEqual(i, result);
            }
        }

        [Test]
        public void Get_FromEmptyBuffer_Throws()
        {
            var buffer = Create();

            Assert.Throws<InvalidOperationException>(() => buffer.Get());
        }

        private static ICircularBuffer<int> Create()
        {
            const int size = 10;

            var result = new CircularBuffer<int>(size);

            return result;
        }
    }
}
