using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeServiceProvision.Models
{
    public class Order
    {
        public DateTime DateTime { get; set; }
        public String status { get; set; }
        public List<String> cart;

    }
}