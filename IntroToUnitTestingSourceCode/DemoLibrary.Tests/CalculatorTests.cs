using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        //[Fact]
        [Theory]
        //Arrange
        [InlineData(2,5,7)]
        [InlineData(25,25.2, 50.2)]
        [InlineData(double.MaxValue,5,double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide_SimpleValuesshouldCalculate(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            //
            double expected  = 0 ;
            //Act
            double actual = Calculator.Divide(15,0);
            //Assert
            Assert.Equal(expected, actual);
        }





    }
}  
