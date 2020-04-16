using NUnit.Framework;

namespace Components.Tests
{
    [TestFixture]
    public class Test4StringTests
    {
        [Test]
        public void SomeTest()
        {
            // Arrange
            var sut = new Test4String();

            // Act
            var result = sut.StringCounterAsStackApproach("aaabbcdeeee");

            // Assert
            Assert.AreEqual("4edc2b3a", result);
        }
    }
}