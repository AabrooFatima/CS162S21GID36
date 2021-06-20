using HomeServiceProvision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeServiceProvision.Controllers
{
    public class CustomerController : Controller
    { 
    [HttpPost]
        public bool addCust(Customer obj)
    {
        bool f = false;
        Receipt.Users.Add(obj);
        f = true;
        return f;
    }
    [HttpPost]
    public bool delCust(String id)
    {
        bool f = false;
        for (int i = 0; i < Receipt.Users.Count; i++)
        {
            if (Receipt.Users[i].ID == id)
            {
                Receipt.Users.RemoveAt(i);
                f = true;
            }
        }
        return f;
    }
    [HttpPost]
    public bool editCust(String id, Customer obj)
    {
        bool f = false;
        for (int i = 0; i < Receipt.Users.Count; i++)
        {
            if (Receipt.Users[i].ID == id)
            {
                Receipt.Users.Insert(i, obj);
                f = true;
            }

        }
        return f;
    }
    [HttpGet]
    public List<Customer> viewCust()
    {
        return Receipt.Users;
    }
    [HttpGet]
    public Order viewOrder()
    {
        return Customer.Order;
    }
    
    }
}