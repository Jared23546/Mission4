using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        
        //variables
        private MovieContext movieContext { get; set; }

        //constructor
        public HomeController(MovieContext temp)
        {
            movieContext = temp;
        }

        //index
        public IActionResult Index()
        {
            return View();
        }

        //MyPodcasts
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Enter Movies get and post
        [HttpGet]
        public IActionResult EnterMovies()
        {
            ViewBag.Categories = movieContext.Categories.ToList(); //pull in data, make it a list, and put it in viewbag.categories

            return View();
        }
        [HttpPost]
        public IActionResult EnterMovies(MovieResponse mr)
        {
            movieContext.Add(mr);
            movieContext.SaveChanges();

            return View("Confirmation");
        }

        //movie list 
        public IActionResult MovieList()
        {
            var movies = movieContext.Responses
                .Include(x => x.Category) // this includes the category object so that it can be accessed in the view
                .ToList(); // this gets the dataset and puts it into a list format for us to read


            return View(movies);
        }

        //edit get and post
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            //set up the view bag with majors so that the entermovies view has them and it doesnt crash
            ViewBag.Categories = movieContext.Categories.ToList();

            //grab the movie where the movieid is the same as the one passed
            var Movie = movieContext.Responses.Single(x => x.MovieId == movieid);

            return View("EnterMovies", Movie); // go to the entermovies view but already have all the information for the movie that is being edited filled out
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse blah)
        {
            movieContext.Update(blah); // update and save all the changes
            movieContext.SaveChanges();

            return RedirectToAction("MovieList"); //redirect them to the movie list action
        }

        //delete get and post
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            //grab the movie where the movieid is the same as the one passed
            var Movie = movieContext.Responses.Single(x => x.MovieId == movieid);
            return View(Movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse ar)
        {
            //for this to work we need an asp for in the delete form so create a hidden one
            movieContext.Responses.Remove(ar);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }


    }
}
