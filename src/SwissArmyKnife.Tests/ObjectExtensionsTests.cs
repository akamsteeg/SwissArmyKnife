using System.IO;
using Xunit;

namespace SwissArmyKnife.Tests
{
    public class ObjectExtensionsTests
    {
        #region IsAnyOf()

        [Fact]
        public void StringIsAnyOfSingleValue_Successful()
        {
            var t1 = "test".IsAnyOf("test");
            var t2 = "test".IsAnyOf("not test");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfTwoValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake");
            var t2 = "test".IsAnyOf("not test", "fake");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfThreeValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1");
            var t2 = "test".IsAnyOf("not test", "fake0", "fake1");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfFourValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1", "fake2");
            var t2 = "test".IsAnyOf("not test", "fake0", "fake1", "fake2");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void StringIsAnyOfManyValues_Successful()
        {
            var t1 = "test".IsAnyOf("test", "fake0", "fake1", "fake2", "fake3");
            var t2 = "test".IsAnyOf("not test", "fake0", "fake1", "fake2", "fake3");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfSingleValue_Successful()
        {
            var t1 = 1.IsAnyOf(1);
            var t2 = 1.IsAnyOf(2);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfTwoValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2);
            var t2 = 1.IsAnyOf(2, 3);

            Assert.True(t1);
            Assert.False(t2);
        }
        [Fact]
        public void IntIsAnyOfThreeValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3);
            var t2 = 1.IsAnyOf(-1, 2, 3);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfFourValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4);
            var t2 = 1.IsAnyOf(-1, 2, 3, 4);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsAnyOfManyValues_Successful()
        {
            var t1 = 1.IsAnyOf(1, 2, 3, 4, 5);
            var t2 = 1.IsAnyOf(-1, 2, 3, 4, 6);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void EnumIsAnyOfManyValues_Successful()
        {
            var t1 = FileMode.Open.IsAnyOf(FileMode.Append, FileMode.Open);
            var t2 = FileMode.Open.IsAnyOf(FileMode.Append, FileMode.Create);

            Assert.True(t1);
            Assert.False(t2);
        }

        #endregion
    }
}
