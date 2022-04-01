using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
namespace Tests
{
    [TestClass]
    public class CalcTests
    {
        //Arrange
        [DataRow(4,5,9)]
        [DataRow(10,20,30)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue(int a, int b,int expected)
        {
            //Arrange
            //int a = 5;
            //int b = 10;
            //int expected = 15;
            //Act
            int actual  = Calcs.Sum(a, b);
            //Assert

            //equals compara que las referencias sean las mismas ( mismo espacio de memoria)
            //Are equal es para comparar valor
            Assert.AreEqual(expected, actual);
            
        }
    }
}
   