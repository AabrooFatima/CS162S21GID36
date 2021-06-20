using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeServiceProvision.Models
{
    public class Cash implements Payment
    {
        public void payBill()
        {
           Order.status = "Bill Payed";
        }
        public void generateReceipt()
        {
           
        }
    }
}