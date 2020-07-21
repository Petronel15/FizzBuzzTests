using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        public void ExecuteTest(int value,string expected)
        {
            //Arrange

            //Act
            string result = fizzBuzz.Convert(value);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnValue()
        {
            ExecuteTest(17, "17");
        }

        [Test]
        public void ShouldReturnFizz()
        {
            ExecuteTest(9, "Fizz");
        }

        [Test]
        public void ShouldReturnBuzz()
        {
            ExecuteTest(20, "Buzz");
        }

        [Test]
        public void ShouldReturnFizzBuzz()
        {
            ExecuteTest(30, "FizzBuzz");
        }
    }
}
