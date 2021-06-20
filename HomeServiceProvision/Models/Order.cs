using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeServiceProvision.Models
{
    public class Order
    {
        public String dateTime
        {
            get
            {
                return this.dateTime;
            }

            set
            {
                dateTime = DateTime.Now.ToString();
            }
        }
        public String status { get; set; }
        public List<Services> cart;
        public int total
        {
            get
            {
                return this.total;
            }

            set
            {
                for (int i = 0; i < this.cart.Count; i++)
                {
                    total = total + this.cart[i].charges;
                }

            }

        }
    }
}