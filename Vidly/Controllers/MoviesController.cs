using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Baghi"};
            var customer = new List<Customers>
            {
                new Customers {name="Customer 1" },
                new Customers {name="Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };

            return View(viewModel);
        }

        
        public ActionResult i(int i)
        {
            return Content("saurabh");
        }

        public ActionResult j(string name,int? id)
        {
            if (id.HasValue)
            {
                id = 1;
            }

            if (string.IsNullOrWhiteSpace(name))
            {

                name = "saurabh";

            }

            return Content(string.Format("name={0}&id={1}",name,id));
        }

        public ActionResult ByReleaseDate(int month,int year)
        {
            return Content(month + "/" + year);
        }


        VidlyEntities db = new VidlyEntities();
        List<Movie> lst = new List<Movie>();
        public ActionResult Index()
        {



            lst = db.Movies.ToList();
            return View(lst);
        }

        public ActionResult particular(string name,string genre,DateTime release,int nis)
        {
            ViewBag.n = name;
            ViewBag.genre = genre;
            ViewBag.release = release;
            ViewBag.nis = nis;

            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult New(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                if (movie.Id == 0)

                    db.Movies.Add(movie);


                try
                {

                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine(e);
                }

                catch(DbEntityValidationException e)
                {
                    Console.WriteLine(e);
                }
                return View();
            }
            
            return RedirectToAction("Index", "Movies");
        }
        
    }
}