using NTTData.Business;
using NTTData.Dto;

namespace Demo.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            Request rq = new Request { to = "Gus" };
            string expectedMessage = "Hello Gus your message will be send!!";
            Core ser = new Core();

            // Act
            Response response = ser.GetWelcome(rq);

            // Assert

            Assert.AreNotEqual(expectedMessage, response.message);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            // Arrange
            Request rq = new Request { to = "Gus" };
            string expectedMessage = "Hello Gus your message will be send!!";
            Core ser = new Core();

            // Act
            Response response = ser.GetWelcome(rq);

            // Assert

            Assert.AreNotEqual(expectedMessage, response.message);
            Assert.Pass();
        }
    }
}