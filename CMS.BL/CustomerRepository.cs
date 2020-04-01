using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BL
{
    public class CustomerRepository
    {
        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //code that retrieves the defined customer


            //Temporary hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.emailAddress = "16211A0583@bvrit.ac.in";
                customer.FirstName = "Ritesh";
                customer.LastName = "Yadav";

            }
            return customer;
        }

        //Saves the current customer
        public bool Save()
        {
            return true;
        }
    }
}
