using NUnit.Framework;
using SwissArmyKnife;
using SwissArmyKnife.Extensions;

namespace SwissArmyKnife.Tests.Extensions
{
    [TestFixture]
    internal class GenericExtensionsTests
    {
        #region IsAnyOf()

        [Test]
        public void StringIsAnyOfSingleValue_Successful()
        {
            var t1 = "test".IsAnyOf("test");
            var t2 = "test".IsAnyOf("not test");

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void StringIsAnyOfTwoValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake");
            var t2 = "test".IsAnyOf("not test", "fake");

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void StringIsAnyOfThreeValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1");
            var t2 = "test".IsAnyOf("not test", "fake0", "fake1");

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void StringIsAnyOfFourValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1", "fake2");
            var t2 = "test".IsAnyOf("not test", "fake0", "fake1", "fake2");

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void StringIsAnyOfManyValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1", "fake2", "fake3");
            var t2 = "test".IsAnyOf("not test", "fake0", "fake1", "fake2", "fake3");

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void IntIsAnyOfSingleValue_Successful()
        {
            var t1 = 1.IsAnyOf(1);
            var t2 = 1.IsAnyOf(2);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void IntIsAnyOfTwoValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2);
            var t2 = 1.IsAnyOf(2, 3);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }
        [Test]
        public void IntIsAnyOfThreeValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3);
            var t2 = 1.IsAnyOf(-1, 2, 3);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void IntIsAnyOfFourValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4);
            var t2 = 1.IsAnyOf(-1, 2, 3, 4);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void IntIsAnyOfManyValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4, 5);
            var t2 = 1.IsAnyOf(-1, 2, 3, 4, 6);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        #endregion

        #region IsBetween()

        [Test]
        public void StringIsBetween_Successful()
        {
            var t1 = "b".IsBetween("a", "c");
            var t2 = "z".IsBetween("a", "c");

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void IntIsBetween_Successful()
        {
            var t1 = 1.IsBetween(0, 2);
            var t2 = 9.IsBetween(0, 2);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void DoubleIsBetween_Successful()
        {
            var t1 = 1.1.IsBetween(1.0, 1.5);
            var t2 = 9.0.IsBetween(1.0, 2.0);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        [Test]
        public void IsBetweenNullValues_Successful()
        {
            var t1 = "b".IsBetween(null, "c");
            var t2 = "b".IsBetween("a", null);
            var t3 = "b".IsBetween(null, null);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
            Assert.IsFalse(t3);
        }
        #endregion
    }
}
