using System;
using CMS.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
               
                emailAddress = "16211A0583@bvrit.ac.in",
                FirstName ="Ritesh",
                LastName = "Yadav"
            };

            //--Act 
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId,actual.CustomerId);
            Assert.AreEqual(expected.emailAddress, actual.emailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
