using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using RecordShop.ViewModels;

namespace RecordShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //get random record
        public IActionResult Random()
        {
            var record = new Record() {
                Name = "Test Record!",
                Genre = "Pop",
                Artist = "Linkin Park",
                Description = "This is an Album",
                Price = 12
            };

            //temp creating list of customers
            var customers = new List<Customer>
            {
                new Customer {Name = "Cust 1"},
                new Customer {Name = "Cust 2"},
            };

            //create viewmodel object
            var viewModel = new RandomRecordViewModel
            {
                Record = record,
                Customers = customers
            };

            //return random record from dict
            ViewData["Record"] = record;
            return View(viewModel); //return viewmodel here
            
        }

        //edit record referenced by ID
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Album(int ID)
        {
            return View();
        }

        public IActionResult RecordList()
        {
            return View();
        }

        public IActionResult AddRecord()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            List<Record> records = new List<Record>()
            {
                new Record() { Name = "Record 1", Price = 13.5M },
                new Record() { Name = "Record 2", Price = 13.5M },
                new Record() { Name = "Record 3", Price = 13.5M },
                new Record() { Name = "Record 4", Price = 13.5M },
                new Record() { Name = "Record 5", Price = 13.5M },
                new Record() { Name = "Record 6", Price = 13.5M },
                new Record() { Name = "Record 7", Price = 13.5M },
                new Record() { Name = "Record 8", Price = 13.5M },
                new Record() { Name = "Record 9", Price = 13.5M },
                new Record() { Name = "Record 10", Price = 13.5M },
            };

            var viewModel = new RecordList()
            {
                Records = records
            };
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
