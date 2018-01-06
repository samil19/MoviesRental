using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesRental.Models
{
    public class RandomMovieViewModel
    {
        public List<Movies> Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}