using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public decimal? CurrentPrice { get; set; }

       

        //Validates the product data
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;
            return isValid;
        }
    }
}
