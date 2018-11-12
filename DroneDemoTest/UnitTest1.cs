using DroneDemo;
using Xunit;

namespace DroneDemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMessage()
        {
            var processor = new MessageProcessor();
            Assert.Equal("Hello, World!", processor.GetMessage());
        }
    }
}
