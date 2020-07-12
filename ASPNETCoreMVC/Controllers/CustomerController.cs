using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNETCoreMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveCustomer()
        {
            return View(new CustomerViewModel());
        }

        [HttpPost]
        public IActionResult SaveCustomer(Customer customer)
        {
            return Ok();
        }
    }
}
