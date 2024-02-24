using Xunit;

namespace Sunday_Test
{
    public class WebTest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 5;
            bool result = false;
            if (i == 5) result = true;
            Assert.True(result, "Value should be equal to 1");
        }
    }
}