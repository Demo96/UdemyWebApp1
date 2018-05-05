using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyWebApp1.Models;

namespace UdemyWebApp1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}