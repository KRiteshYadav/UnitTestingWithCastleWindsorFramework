using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BL
{
    public  class ServiceImpl : Service
    {
        ICustomer cust;

        public ServiceImpl(ICustomer cus)
        {
            this.cust = cus;
        }
        public bool Validate()
        {
            return cust.Validate();
        }
    }
}
