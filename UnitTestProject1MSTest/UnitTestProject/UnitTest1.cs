using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;

namespace UnitTEstProject1MSTest
{
    [TestClass] // esa referencia por cada clase
    public class Test_CalculadoraEjemplo
    {
        [TestMethod] //TestMethod por cada metodo
        public void Test_Suma_Correcta()
        {
            //Arrange: Inicializamos variables 
            int sumando1 = 2;
            int sumando2 = 5;

            //Act:Ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo.Suma(sumando1, sumando2);

            //Assert: Comprobacion de los valores
            Assert.AreEqual(sumando1 + sumando2, resultado);

        }
        [TestMethod]
        public void Test_Resta_Correcta()
        {
            //Arrange: Inicializamos variables 
            int sumando1 = 5;
            int sumando2 = 3;

            //Act:Ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo.Resta(sumando1, sumando2);

            //Assert: Comprobacion de los valores
            Assert.AreEqual(sumando1 - sumando2, resultado);

        }
        [TestMethod]
        public void Test_Division_Correcta()
        {
            //Arrange: Inicializamos variables 
            int sumando1 = 2;
            int sumando2 = 5;

            //Act:Ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo.Division(sumando1, sumando2);

            //Assert: Comprobacion de los valores
            Assert.AreEqual(sumando1 / sumando2, resultado);

        }
        [TestMethod]
        public void Test_Multiplicacion_Correcta()
        {
            //Arrange: Inicializamos variables 
            int sumando1 = 2;
            int sumando2 = 5;

            //Act:Ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo.Multiplicacion(sumando1, sumando2);

            //Assert: Comprobacion de los valores
            Assert.AreEqual(sumando1 * sumando2, resultado);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void test_excepcion()
        {
            //En MSTest las excepciones se define otro atributo, en xunit si se puede
            int dividendo = 120;
            int divisor = 0;
            double resultado = CalculadoraEjemplo.Division(dividendo, divisor);


        }
    }
}
