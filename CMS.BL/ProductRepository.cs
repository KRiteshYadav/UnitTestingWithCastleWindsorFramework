using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            //code that retrieves the defined product


            //Temporary hard-coded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "R10";
                product.ProductDescription = "Point of sale application";
                product.CurrentPrice = 10.5M;

            }
            return product;
        }

        //Saves the current product
        public bool Save(Product product)
        {
            return true;
        }
    }
}
