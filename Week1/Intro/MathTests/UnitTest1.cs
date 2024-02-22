using Maths;

namespace MathTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckMultiplyFunction()
        {
            // Arrange
            var number = new Number(5);

            // Act
            var result = number.Multiplier();

            // Assertion
            Assert.Equal(10, result);
        }

        [Fact]

        public void CheckMultiplyFunctionWithParameter()
        {
            // Arrange
            var number = new Number(60);

            // Act
            var result = number.Multiplier(2);

            // Assertion
            Assert.True(result == 120);
            Assert.Equal(120, result);
        }



    }
}