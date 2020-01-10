using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Customers()
        {
            var movie = new Movie() { Name = "Baghi" };
            ViewData["Movie"] = movie;
            return View(movie);
        }
      
    }
}