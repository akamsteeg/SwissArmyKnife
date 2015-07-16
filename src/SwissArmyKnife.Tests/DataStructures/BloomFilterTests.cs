using NUnit.Framework;
using SwissArmyKnife.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
