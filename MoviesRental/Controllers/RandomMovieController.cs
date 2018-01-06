using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRental.Models;

namespace MoviesRental.Controllers
{
    public class RandomMovieController : Controller
    {
        // GET: RandomMovie
        public ActionResult RandomMovie()
        {
            var movie = new List<Movies>
            {
                new Movies {Name = "Enemy of the State"},
                new Movies {Name = "Hunger Games"}

            };
            var customer = new List<Customer>
            {
               new Customer {Name = "NSA", ID = 1},
                new Customer {Name = "CIA", ID = 2},
                new Customer {Name = "FBI", ID = 3}
            } ;

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };
            return View(ViewModel);
        }

        public ActionResult Details(string name)
        {
            var hello = "Soy samiil";
            var again = new Customer {Name = name};

            return View(again);
        }

        public ActionResult ShowCustomers()
        {
            var customer = new List<Customer>
            {
                new Customer {Name = "NSA", ID = 1},
                new Customer {Name = "CIA", ID = 2},
                new Customer {Name = "FBI", ID = 3}
            };

            var viewModel1 = new RandomMovieViewModel
            {
                Customers = customer
            };

            return View(viewModel1);
        }

        public ActionResult ShowMovies()
        {
            var movie = new List<Movies>
            {
                new Movies {Name = "Enemy of the State"},
                new Movies {Name = "Hunger Games"}
            };
        var viewModel = new RandomMovieViewModel
        {
            Movie = movie
        };
            return View(viewModel);
        }
    }
}