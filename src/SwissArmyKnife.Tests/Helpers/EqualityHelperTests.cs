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
        public void EqualsTT_WithOtherNull_ReturnsFalse()
        {
            var result = EqualityHelper.Equals("Dummy", (string)null);

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
        public void EqualsTT_WithOtherSameObject_ReturnsTrue()
        {
            var o = "Dummy";

            var result = EqualityHelper.Equals(o, o);

            Assert.True(result);
        }
    }
}
