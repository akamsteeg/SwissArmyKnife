using Xunit;

namespace SwissArmyKnife.Tests
{
    public class IComparableExtensionsTests
    {
        #region IsBetween()

        [Fact]
        public void StringIsBetween_Successful()
        {
            var t1 = "b".IsBetween("a", "c");
            var t2 = "z".IsBetween("a", "c");

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IntIsBetween_Successful()
        {
            var t1 = 1.IsBetween(0, 2);
            var t2 = 9.IsBetween(0, 2);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void DoubleIsBetween_Successful()
        {
            var t1 = 1.1.IsBetween(1.0, 1.5);
            var t2 = 9.0.IsBetween(1.0, 2.0);

            Assert.True(t1);
            Assert.False(t2);
        }

        [Fact]
        public void IsBetweenNullValues_Successful()
        {
            var t1 = "b".IsBetween(null, "c");
            var t2 = "b".IsBetween("a", null);
            var t3 = "b".IsBetween(null, null);

            Assert.True(t1);
            Assert.False(t2);
            Assert.False(t3);
        }
        #endregion
    }
}
