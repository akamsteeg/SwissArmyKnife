using NUnit.Framework;
using SwissArmyKnife.DataStructures;
using System;
using System.Text;

namespace SwissArmyKnife.Tests.DataStructures
{
    [TestFixture]
    internal class BloomFilterTests
    {
        [Test]
        public void AddAndTest_Successful([Values("a", "b", "c", "d", "lorem ipsum dolor sit amet")]string input)
        {
            var bf = new BloomFilter(64);

            var testData = Encoding.ASCII.GetBytes(input);

            bf.Add(testData);

            var result = bf.Test(testData);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestWithoutAdd_Successful([Values("a", "b", "c", "d", "lorem ipsum dolor sit amet")]string input)
        {
            var bf = new BloomFilter(64);

            var testData = Encoding.ASCII.GetBytes(input);

            var result = bf.Test(testData);

            Assert.IsFalse(result);
        }

        [Test]
        public void InitializesWithZeroSize_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new BloomFilter(0));
        }

        [Test]
        public void AddNull_Throws()
        {
            var bf = new BloomFilter(64);

            byte[] input = null;

            Assert.Throws<ArgumentNullException>(() => bf.Add(input));
        }

        [Test]
        public void AddEmpty_Throws()
        {
            var bf = new BloomFilter(64);

            byte[] input = new byte[0];

            Assert.Throws<ArgumentException>(() => bf.Add(input));
        }

        [Test]
        public void TestWithNull_Throws()
        {
            var bf = new BloomFilter(64);

            byte[] input = null;

            Assert.Throws<ArgumentNullException>(() => bf.Add(input));
        }

        [Test]
        public void TestWithEmpty_Throws()
        {
            var bf = new BloomFilter(64);

            byte[] input = new byte[0];

            Assert.Throws<ArgumentException>(() => bf.Add(input));
        }
    }
}
