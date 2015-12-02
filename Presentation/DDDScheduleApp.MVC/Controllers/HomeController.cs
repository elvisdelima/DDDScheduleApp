using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DDDScheduleApp.Entities;

namespace DDDScheduleApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var c = new DDDScheduleApp.Entities.Client();
            return View();
        }
      
        public IActionResult Error()
        {
            return View();
        }
    }
}
