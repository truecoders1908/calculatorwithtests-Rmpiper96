using System;
using Xunit;
namespace CalculatorWithTests.Tests
{
    public class CalculatorTests
    {

        [Theory]
        [InlineData(1, 7, 8)]
        [InlineData(10, 10, 20)]
        [InlineData(99, 30, 129)]
        [InlineData(-10, -10, -20)]
        [InlineData(-1, 3, 2)]
        [InlineData(0, 1, 1)]
        [InlineData(4, 7, 11)]
        [InlineData(-1, 0, -1)]
        [InlineData(5, 2, 7)]

        public void AddIntigers(int number1, int number2, int expected)
        {
            // Arrange
            Calculator TheTest = new Calculator();

            // Act
            int actual = TheTest.AddIntigers(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 7, -6)]
        [InlineData(10, 10, 0)]
        [InlineData(99, 30, 69)]
        [InlineData(-10, -10, 0)]
        [InlineData(-1, 3, -4)]
        [InlineData(0, 1, -1)]
        [InlineData(4, 7, -3)]
        [InlineData(-1, 0, -1)]
        [InlineData(5, 2, 3)]

        public void Subtract(int minuend, int subtraend, int expected)
        {
            // Arrange
            Calculator TheTest = new Calculator();

            // Act
            int actual = TheTest.Subtract(minuend, subtraend);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 7, 7)]
        [InlineData(10, 10, 100)]
        [InlineData(99, 30, 2970)]
        [InlineData(-10, -10, -100)]
        [InlineData(-1, 3, -3)]
        [InlineData(0, 1, 0)]
        [InlineData(4, 7, 28)]
        [InlineData(-1, 0, 0)]
        [InlineData(5, 2, 10)]

        public void multiplyTheNumbers(int number1, int number2, int expected)
        {
            // Arrange
            Calculator TheTest = new Calculator();

            // Act
            int actual = TheTest.multiplyTheNumbers(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 7, 8)]
        [InlineData(10, 10, 20)]
        [InlineData(99, 30, 129)]
        [InlineData(-10, -10, -20)]
        [InlineData(-1, 3, 2)]
        [InlineData(0, 1, 1)]
        [InlineData(4, 7, 11)]
        [InlineData(-1, 0, -1)]
        [InlineData(5, 2, 7)]

        public void divideTheNumbers(int number1, int divisor, int expected)
        {
            // Arrange
            Calculator TheTest = new Calculator();

            // Act
            int actual = TheTest.divideTheNumbers(number1, divisor);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 3628800)]
        [InlineData(7, 5040)]
        [InlineData(5, 120)]
        [InlineData(9, 362880)]
        [InlineData(11, 39916800)]
        [InlineData(4, 24)]
        [InlineData(12, 479001600)]
        [InlineData(8, 40320)]

        public void factorializeTheNumber(int number1, int expected)
        {
            // Arrange
            Calculator TheTest = new Calculator();

            // Act
            int actual = TheTest.factorializeTheNumber(number1);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
