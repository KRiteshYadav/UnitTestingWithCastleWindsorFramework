using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CMS.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CMS.BLTest
{
    

    [TestClass]
    public class CustomerTest
    {
        Service service;



        [TestInitialize]
        public void initialize()
        {
            var container = new WindsorContainer();



            container.Register(Component.For<ICustomer>().ImplementedBy<Customer>());



            container.Register(Component.For<Service>().ImplementedBy<ServiceImpl>());



            service = container.Resolve<Service>();
        }

        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer {
                FirstName = "Ritesh",
                LastName = "Yadav"
        };
            string expected = "Yadav, Ritesh";

            //--Act
            string actual = customer.FullName;

            //--Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Yadav,"
            };
            string expected = "Yadav,";

            //--Act
            string actual = customer.FullName;

            //--Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {

                FirstName = "Ritesh"
            };
            string expected = "Ritesh";

            //--Act
            string actual = customer.FullName;

            //--Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Yadav",
                emailAddress = "riteshyadav654@gmail.com"
            };
            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {
    
                emailAddress = "riteshyadav654@gmail.com"
            };
            var expected = false;

            //--Act
            var actual = service.Validate();

            //--Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
