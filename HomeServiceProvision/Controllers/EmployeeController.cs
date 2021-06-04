using HomeServiceProvision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeServiceProvision.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpPost]
        public bool addEmp(Employee obj)
        {
            bool f = false;
            Receipt.Staff.Add(obj);
            f = true;
            return f;
        }
        [HttpPost]
        public bool delEmp(String id)
        {
            bool f = false;
            for (int i = 0; i < Receipt.Staff.Count; i++)
            {
                if (Receipt.Staff[i].ID== id)
                {
                    Receipt.Staff.RemoveAt(i);
                    f = true;
                }
            }
            return f;
        }
        [HttpPost]
        public bool editEmp(String id, Employee obj)
        {
            bool f = false;
            for(int i=0;i<Receipt.Staff.Count;i++)
            {
                if(Receipt.Staff[i].ID==id)
                {
                    Receipt.Staff.Insert(i, obj);
                    f = true;
                }

            }
            return f;
        }
        [HttpGet]
        public List<Employee> viewEmp()
        {
            return Receipt.Staff;        }
    }
}