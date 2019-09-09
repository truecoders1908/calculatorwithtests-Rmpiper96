using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Calculator
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
        
        public void Add(int number1, int number2, int expected)
        {
            // Arrange
            CalculatorTests TheTest = new CalculatorTests();
            
            // Act
            int actual = TheTest.Add(number1, number2);
            
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
            CalculatorTests TheTest = new CalculatorTests();

            // Act
            int actual = TheTest.Subtract(minuend, subtraend);
        }
    }
}
