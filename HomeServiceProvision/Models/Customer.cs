using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeServiceProvision.Models
{
    public class Customer : Person
    {
        public String ID { get; set; }
        public String pass {get; set;}
        public Feedback views { get; set; }

    }
}