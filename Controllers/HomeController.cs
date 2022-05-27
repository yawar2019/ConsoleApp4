using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp4.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [Route("Home")]
        [Route("Home/AboutUs")]
        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet("Home/MyContact")]
        public ActionResult ContactUS()
        {
            return View();
        }

        [HttpGet("{id:int?}")]
        public ActionResult Dashboard(int? id)
        {
            return View();
        }
    }
}
