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
            HttpContext.Session.SetString("Name", "Tural");
            return "Saved";
        }

        public string Index2()
        {
           return HttpContext.Session.GetString("Name");
        }
    }
}
