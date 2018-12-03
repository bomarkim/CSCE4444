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
            //return View(record);
            return Content("Hello World");
        }
    }
}