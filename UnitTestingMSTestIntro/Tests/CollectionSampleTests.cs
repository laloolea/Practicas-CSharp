using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CollectionSampleTests
    {
        
        [TestMethod]
        public void getCustomer_ShouldGetSameCustomer()
        {
            //Arrange
            Customer[] customers = new Customer[2] { new Customer { FirstName = "John", LastName = "Ford" }, new Customer { FirstName = "Billy", LastName = "Hola" } };
            int index = 1;

            Customer expected = customers[index];
            //act

            Customer actual = CollectionsSample.GetCustomer(customers, index);
            //assert
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);
        }

       [ExpectedException(typeof(IndexOutOfRangeException))]
       [TestMethod]
       public void GetCustomer_ShouldThrowIndexOutofRangeException()
        {
            //Arrange
            Customer[] customers = new Customer[2] { new Customer { FirstName = "John", LastName = "Ford" }, new Customer { FirstName = "Billy", LastName = "Hola" } };
            int index = 5;


            //act
             
            CollectionsSample.GetCustomer(customers, index);


            //assert
            // you dont need to put of assert. with the decorator is enough
           
        }
    }
}
