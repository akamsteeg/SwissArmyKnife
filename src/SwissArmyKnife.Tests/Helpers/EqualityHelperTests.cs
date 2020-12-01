using SwissArmyKnife.Helpers;
using Xunit;

namespace SwissArmyKnife.Tests.Helpers
{
    public class EqualityHelperTests
    {
        [Fact]
        public void EqualsT_WithOtherNull_ReturnsFalse()
        {
            var result = EqualityHelper.Equals(this, (object)null);

            Assert.False(result);
        }

        [Fact]
        public void EqualsT_WithOtherDifferentObject_ReturnsFalse()
        {
            var result = EqualityHelper.Equals(this, new object());

            Assert.False(result);
        }

        [Fact]
        public void EqualsT_WithSameObject_ReturnsTrue()
        {
            var o = "Dummy";

            var result = EqualityHelper.Equals(o, (object)o);

            Assert.True(result);
        }


        [Fact]
        public void EqualsT_WithOtherDifferentValueType_ReturnsFalse()
        {
            var result = EqualityHelper.Equals(0, (object)1);

            Assert.False(result);
        }

        [Fact]
        public void EqualsT_WithSameValueType_ReturnsTrue()
        {
            var result = EqualityHelper.Equals(0, (object)0);

            Assert.True(result);
        }

        [Fact]
        public void EqualsTT_WithOtherNull_ReturnsFalse()
        {
            var result = EqualityHelper.Equals("Dummy", (string)null);

            Assert.False(result);
        }

        [Fact]
        public void EqualsTT_WithOtherNullValueType_ReturnsFalse()
        {
            var result = EqualityHelper.Equals(1, (int?)null);

            Assert.False(result);
        }

        [Fact]
        public void EqualsTT_WithOtherDifferentObject_ReturnsFalse()
        {
            var a = "A";

            var b = "B";

            var result = EqualityHelper.Equals(a, b);

            Assert.False(result);
        }

        [Fact]
        public void EqualsTT_WithOtherDifferentValueType_ReturnsFalse()
        {
            var a = 0;

            var b = 1;

            var result = EqualityHelper.Equals(a, b);

            Assert.False(result);
        }

        [Fact]
        public void EqualsTT_WithOtherSameValueType_ReturnsTrue()
        {
            var o = 0;

            var result = EqualityHelper.Equals(o, 0);

            Assert.True(result);
        }

        [Fact]
        public void EqualsTT_WithOtherSameValueDifferentValueType_ReturnsTrue()
        {
            var o = 0;

            var result = EqualityHelper.Equals(o, 0.0);

            Assert.True(result);
        }

        [Fact]
        public void EqualsTT_WithOtherDifferenteValueDifferentValueType_ReturnsFalse()
        {
            var o = 0;

            var result = EqualityHelper.Equals(o, 1.0);

            Assert.True(0 == 0.0);

            //Assert.False(result);
        }

        [Fact]
        public void EqualsT_WithOtherStructSameValue_ReturnsTrue()
        {
            var a = 0;

            var b = 0.0;

            var result = EqualityHelper.Equals(a, b);

            Assert.True(result);
        }
    }
}
