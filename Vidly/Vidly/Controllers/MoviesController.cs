using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models; // using the movies from the model

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


            return View(movie);  
        }
    }
}