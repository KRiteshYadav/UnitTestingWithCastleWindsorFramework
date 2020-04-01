﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //Retrieve one order item
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        //Save the current order item
        public bool Save()
        {
            return true;
        }

        //Validate the order item data 
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0)
                isValid = false;
            if (ProductId <= 0)
                isValid = false;
            if (PurchasePrice == null)
                isValid = false;
            return isValid;
        }
    }
}
