using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreMVC.Entities;
using ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNETCoreMVC.Controllers
{
    //Attribute Routing
    [Route(template:"Test")]
    public class CustomerController : Controller
    {
        [Route(template: "Home")] // Action name
        [Route(template: "")] // Default Action
        [Route(template: "~/Anasayfa")] //domain/Anasayfa
        public IActionResult Index()
        {
            return View();
        }

        [Route(template: "Save")]
        public IActionResult SaveCustomer()
        {

            return View(new CustomerViewModel
            {
                cities = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Baki", Value="10"},
                    new SelectListItem{ Text="Xizi", Value="29"},
                    new SelectListItem{ Text="Absheron", Value="01"}
                }
            });
        }

        [HttpPost]
        public IActionResult SaveCustomer(Customer customer)
        {
            return Ok();
        }
    }
}
