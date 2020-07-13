using ASPNETCoreMVC.Entities;
using ASPNETCoreMVC.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index1()
        {
            //HttpContext.Session.SetString("Name", "Tural");
            var customer = new Customer { Name = "Tural", Surname = "Novruzov", City = "Baku" };
            HttpContext.Session.SetObject("customer", customer);
           return "Saved";
        }

        public string Index2()
        {
            //return HttpContext.Session.GetString("Name");
            var customer = HttpContext.Session.GetObject<Customer>("customer");
            return customer.Name;
        }
    }
}
