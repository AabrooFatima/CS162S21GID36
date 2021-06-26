using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeServiceProvision.Models
{
    public class Receipt
    {
        public static List <Employee> Staff= new List<Employee>();
        public static List<Customer> Users = new List<Customer>();
        public static List<Services> ErandServices = new List<Services>();
        public static List<Services> ElectricianServices = new List<Services>();
        public static List<Services> CookServices = new List<Services>();
        public static List<Services> CleanerServices = new List<Services>();
        public static List<Services> PlumbersServices = new List<Services>();
    }
}