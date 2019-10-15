using Xunit;

namespace SwissArmyKnife.Tests
{
    public class IntExtensionTests
    {
        [Fact]
        public void MilliSeconds_Succesfull()
        {
            var result = 1000.MilliSeconds();

            Assert.Equal(1, result.TotalSeconds);
        }

        [Fact]
        public void Seconds_Succesfull()
        {
            var result = 10.Seconds();

            Assert.Equal(10, result.TotalSeconds);
        }

        [Fact]
        public void Minutes_Succesfull()
        {
            var result = 60.Minutes();

            Assert.Equal(3600, result.TotalSeconds);
        }

        [Fact]
        public void Hours_Succesfull()
        {
            var result = 1.Hours();

            Assert.Equal(3600, result.TotalSeconds);
        }

        [Fact]
        public void Days_Succesfull()
        {
            var result = 1.Days();

            Assert.Equal(86400, result.TotalSeconds);
        }
    }
}
