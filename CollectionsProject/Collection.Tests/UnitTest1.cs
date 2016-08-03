using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionsProject;

namespace Collection.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void doesCustomerExist()
        {
            //Arrange
            Customer customer = new Customer();
           
            //Act
            //Assert
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void Customer1Name_ReturnsJohn()
        {
            Customer customer1 = new Customer();

            customer1.ID = 110;
            customer1.Name = "John";
            customer1.Salary = 6500;

            Assert.AreEqual("John", customer1.Name);
        }
       
    }
}
