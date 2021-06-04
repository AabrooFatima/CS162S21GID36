using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeServiceProvision.Models
{
    public class Employee :Person
    {
        public String CNIC { get; set; }
        public String ID { get; set; }
        public String Age{ get; set; }
        public String Expertise { get; set; }
        public String Password { get; set; }

        
        
        
    }
}