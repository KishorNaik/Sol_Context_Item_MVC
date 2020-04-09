using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Items.ContainsKey("MyValue")==true)
            {
                ViewBag.Data = HttpContext.Items["MyValue"] as string;
            }

            return View();
        }
    }
}