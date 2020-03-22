using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models; // using the movies from the model
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //  what ever the methods name is
        public ActionResult Random()    
        {
            //creating an instance of the model
            var movie = new Movies()
            {
                Name="Shrek!"
            };

            var customer = new List<Customer> 
            {
                new Customer{ Name="Cumtomer 1" },
                new Customer{ Name="Cumtomer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            return View(viewModel);  
        }

        // GET: Movies/Edit/1 or Movies/Edit?id=1
        public ActionResult Edit(int id)    // inbed an ID to the end of the url
        {
            return Content("id=" + id); //display this on the page
        }

        // GET: movies                the ine? is making it nullable 
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) // if it doesn't have a value
                pageIndex = 1;


            if (String.IsNullOrWhiteSpace(sortBy)) // if a string a null
                sortBy = "name";

            return Content(String.Format("pageIndex={0}&sortby{1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]   // Attribute Route with some constraints 
        public ActionResult byReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}