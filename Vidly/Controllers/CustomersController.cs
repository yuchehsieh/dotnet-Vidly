using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var movie = new Movie() { Name = "Murphy" };
            var customers = new List<Customer>()
            {
                new Customer() { Name = "Customer1" },
                new Customer() { Name = "Customer2" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            // BAD approach!
            //ViewData["Movie"] = movie;
            //return View();

            return View(viewModel);
        }

        public IActionResult Detail(string customerName)
        {
            var customer = new Customer() { Name = customerName };

            return View(customer);
        }

    }
}
