using System;
using Xunit;

namespace SwissArmyKnife.Tests
{
    public class IComparableExtensionsTests
    {
        #region IsBetween()

        [InlineData("b", "a", "c", true)]
        [InlineData("b", "a", "b", true)]
        [InlineData("b", "b", "b", true)]
        [InlineData("b", "b", "c", true)]
        [InlineData("a", "b", "b", false)]
        [InlineData("a", "b", "c", false)]
        [Theory]
        public void String_IsBetween(string testValue, string lower, string upper, bool expected)
        {
            var result = testValue.IsBetween(lower, upper);

            Assert.Equal(expected, result);
        }

        [InlineData(1, 0, 2, true)]
        [InlineData(1, 0, 1, true)]
        [InlineData(1, 1, 1, true)]
        [InlineData(1, 1, 2, true)]
        [InlineData(0, 1, 1, false)]
        [InlineData(0, 1, 2, false)]
        [Theory]
        public void Int_IsBetween(int testValue, int lower, int upper, bool expected)
        {
            var result = testValue.IsBetween(lower, upper);

            Assert.Equal(expected, result);
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

        #region IsLessThan()

        [InlineData("b", "c", true)]
        [InlineData("b", "b", false)]
        [InlineData("b", "a", false)]
        [Theory]
        public void String_IsLessThan(string testValue, string compareTo, bool expected)
        {
            var result = testValue.IsLessThan(compareTo);

            Assert.Equal(expected, result);
        }

        [InlineData(1, 2, true)]
        [InlineData(1, 1, false)]
        [InlineData(1, 0, false)]
        [Theory]
        public void Int_IsLessThan(int testValue, int compareTo, bool expected)
        {
            var result = testValue.IsLessThan(compareTo);

            Assert.Equal(expected, result);
        }

        #endregion

        #region IsGreaterThan()

        [InlineData("b", "a", true)]
        [InlineData("b", "b", false)]
        [InlineData("a", "b", false)]
        [Theory]
        public void String_IsGreaterThan(string testValue, string compareTo, bool expected)
        {
            var result = testValue.IsGreaterThan(compareTo);

            Assert.Equal(expected, result);
        }

        [InlineData(1, 0, true)]
        [InlineData(1, 1, false)]
        [InlineData(0, 1, false)]
        [Theory]
        public void Int_IsGreaterThan(int testValue, int compareTo, bool expected)
        {
            var result = testValue.IsGreaterThan(compareTo);

            Assert.Equal(expected, result);
        }

        #endregion
    }
}
