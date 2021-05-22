using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void GetFizzBuzz_GivenNumberNotDivisableBy3_ShouldReturnThatNumber(int input, string expected)
        {
            //Arrange
            var sut = CreateFizzBuzz();

            //Act
            var actual = sut.GetFizzBuzz(input);

            //Assert
            //Assert.AreEqual(expected, actual);
            actual.Should().Be(expected);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GetFizzBuzz_GivenNumberDivisableBy3_ShouldReturnFizz(int input)
        {
            //Arrange
            var expected = "Fizz";
            var sut = CreateFizzBuzz();

            //Act
            var actual = sut.GetFizzBuzz(input);

            //Assert
            //Assert.AreEqual(expected, actual);
            actual.Should().BeEquivalentTo(expected);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GetFizzBuzz_GivenNumberDivisableBy5_ShouldReturnBuzz(int input)
        {
            //Arrange
            var expected = "Buzz";
            var sut = CreateFizzBuzz();

            //Act
            var actual = sut.GetFizzBuzz(input);

            //Assert
            actual.Should().Be(expected);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(75)]
        public void GetFizzBuzz_GivenNumberDivisableBy3And5_ShouldReturnFizzBuzz(int input)
        {
            //Arrange
            var expected = "FizzBuzz";
            var sut = CreateFizzBuzz();

            //Act
            var actual = sut.GetFizzBuzz(input);

            //Assert
            actual.Should().Be(expected);
        }

        //[Test]
        //public void learningTest1()
        //{
        //    //Arrange
        //    var input = 6;
        //    var expected = "Fizz";
        //    var sut = CreateFizzBuzz();

        //    //Act
        //    var actual = sut.GetFizzBuzz(input);

        //    //Assert
        //    actual.Should().Be(expected);
        //}
        
        private static FizzBuzzProcessor CreateFizzBuzz()
        {            
            return new FizzBuzzProcessor();
        }
    }
}