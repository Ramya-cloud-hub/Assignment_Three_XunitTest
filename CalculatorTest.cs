using System;
using Xunit;
using Assignment_Three_CalculatorDemo;

namespace Assignment_Three_CalculatorDemo.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            //Arrange
            double[] arr = { 10, 2,10 };
            double expected = 22;
            //Act
            double actual = Calculator.Add(arr);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Sub_SimpleValuesShouldCalculate()
        {
            //Arrange
            double[] arr1 = { (-12), (-3), 5, 24 };
            double expected = -38;

            //Act
            double actual = Calculator.Sub(arr1);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Mul_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 6;

            //Act
            double actual = Calculator.Mul(3, 2);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Div_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 5;

            //Act
            double actual = Calculator.Div(50, 10);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Div_Number_By_Zero_Check()
        {
            //Arrange
            double expected = 0;

            //Act
            double actual = Calculator.Div(8, 0);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10.5,2.3,24.15)]
        [InlineData(0.5,10,5)]
        public void Mul_Double_Number_Check(double x, double y , double expected )
        {
            double actual = Calculator.Mul(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1000, 10, 100)]
        public void Div_Double_Number_Check(double x, double y, double expected)
        {
            double actual = Calculator.Div(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
