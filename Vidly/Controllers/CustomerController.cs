using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        VidlyEntities db = new VidlyEntities();
        List<Customer> lst = new List<Customer>();
        public ActionResult Index()
        {

           

            lst = db.Customers.ToList();
            return View(lst);
        }



        public ActionResult particular(DateTime name)
        {
            ViewBag.bd = name;

            return View();
        }
    }
}