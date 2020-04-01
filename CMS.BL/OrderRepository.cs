using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BL
{
    public class OrderRepository
    {
        //Retrieve one order
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            //code that retrieves the defined order

            //Temporary hard-coded values to return a populated order
            if(orderId==10)
            {
                //Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00,
                    00, 00 ,new TimeSpan(7, 0, 0));

            }
            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
