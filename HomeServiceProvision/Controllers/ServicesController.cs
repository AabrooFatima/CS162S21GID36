using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeServiceProvision.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        [HttpPost]
        public bool addService(String Category, Service obj)
        {
            bool f = false;
            if(Category == "Electrician")
            {
                Receipt.ElectricianServices.add(obj);
                f = true;
            }
            else if(Category == "Plumber")
            {
                Receipt.PlumberServices.add(obj);
                f = true;
            }
            else if(Category == "Cook")
            {
                Receipt.CookServices.add(obj);
                f = true;
            }
            else if(Category == "Errand")
            {
                Receipt.ErrandServices.add(obj);
                f = true;
            }
            else if(Category == "Cleaner")
            {
                Receipt.CleanerServices.add(obj);
                f = true;
            }
            return f;
        }
        [HttpPost]
        public bool delService(String Category, String ServiceName)
        {
            bool f = false;
            if(Category == "Electrician")
            {
                for (int i = 0; i < Receipt.ElectricianServices.Count; i++)
                {
                    if (Receipt.ElectricianServices[i].Name == ServiceName)
                    {
                       Receipt.ElectricianServices.RemoveAt(i);
                       f = true;
                    }
                } 
            }
            else if(Category == "Plumber")
            {
                for (int i = 0; i < Receipt.PlumberServices.Count; i++)
                {
                    if (Receipt.PlumberServices[i].Name == ServiceName)
                    {
                       Receipt.PlumberServices.RemoveAt(i);
                       f = true;
                    }
                } 
            }
            else if(Category == "Cook")
            {
                for (int i = 0; i < Receipt.CookServices.Count; i++)
                {
                    if (Receipt.CookServices[i].Name == ServiceName)
                    {
                       Receipt.CookServices.RemoveAt(i);
                       f = true;
                    }
                } 
            }
            else if(Category == "Errand")
            {
                for (int i = 0; i < Receipt.ErrandServices.Count; i++)
                {
                    if (Receipt.ErrandServices[i].Name == ServiceName)
                    {
                       Receipt.ErrandServices.RemoveAt(i);
                       f = true;
                    }
                } 
            }
            else if(Category == "Cleaner")
            {
                for (int i = 0; i < Receipt.CleanerServices.Count; i++)
                {
                    if (Receipt.CleanerServices[i].Name == ServiceName)
                    {
                       Receipt.CleanerServices.RemoveAt(i);
                       f = true;
                    }
                } 
            }
         }
        [HttpGet]
        public List<Service> viewService(string Category)
        {
            if(Category == "Electrician")
            {
                return Receipt.ElectricianServices;
            }
            else if(Category == "Plumber")
            {
                return Receipt.PlumberServices;
            }
            else if(Category == "Cook")
            {
                return Receipt.CookServices;
            }
            else if(Category == "Cleaner")
            {
                return Receipt.CleanerServices;
            }
            else if(Category == "Errand")
            {
                return Receipt.ErrandServices;
            }
                   
        }
    }
}