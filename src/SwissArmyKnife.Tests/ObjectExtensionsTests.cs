using System.IO;
using NUnit.Framework;

namespace SwissArmyKnife.Tests
{
    [TestFixture]
    public class ObjectExtensionsTests
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

        [Test]
        public void EnumIsAnyOfManyValues_Successful()
        {
            var t1 = FileMode.Open.IsAnyOf(FileMode.Append, FileMode.Open);
            var t2 = FileMode.Open.IsAnyOf(FileMode.Append, FileMode.Create);

            Assert.IsTrue(t1);
            Assert.IsFalse(t2);
        }

        #endregion
    }
}
