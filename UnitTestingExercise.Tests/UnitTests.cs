using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-2, -3, 5, 0)]
        [InlineData(-2, -3, -5, -10)]
        [InlineData(100, 200, 300, 600)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            Calculator calculator = new Calculator();

            var actual = calculator.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-33, -3, -30)]
        [InlineData(33, 33, 0)]
        [InlineData(-33, 3, -36)]
        [InlineData(0, 0, 0)]
        [InlineData(33, 3, 30)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            Calculator calculator = new Calculator();

            var actual = calculator.Subtract(minuend, subtrahend);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-6, 7, -42)]
        [InlineData(-6, -7, 42)]
        [InlineData(6, 7, 42)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            Calculator calculator = new Calculator();

            var actual = calculator.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 1, 100)]
        [InlineData(100, 100, 1)]
        [InlineData(100, -10, -10)]
        [InlineData(-100, -10, 10)]
        [InlineData(100, 10, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator calculator = new Calculator();

            var actual = calculator.Divide(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}
