using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    public class RecordsController : Controller
    {
        //get random record
        public IActionResult Random()
        {
            var record = new Record() {Name = "Test Record!" };
            List<Record> records = new List<Record>() {
                new Record() { Name = "Record 1", Price = 13.5M },
                new Record() { Name = "Record 2", Price = 13.5M},
                new Record() { Name = "Record 3", Price = 13.5M },
                new Record() { Name = "Record 4", Price = 13.5M },
                new Record() { Name = "Record 5", Price = 13.5M },
                new Record() { Name = "Record 6", Price = 13.5M },
                new Record() { Name = "Record 7", Price = 13.5M },
                new Record() { Name = "Record 8", Price = 13.5M },
                new Record() { Name = "Record 9", Price = 13.5M },
                new Record() { Name = "Record 10", Price = 13.5M }
                };
            //return View(record);
            return Content("Hello World");
        }
    }
}