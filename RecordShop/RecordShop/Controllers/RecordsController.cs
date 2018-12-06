using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        [HttpGet]
        public JsonResult getAllRecords()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local);Initial Catalog=RecordShopContext-b49164cf-bf78-4044-8391-2ba48464356a;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User Id=sa;Password=;";
            conn.Open();
            
            var list = new List<Record>();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Record;");
            sqlCommand.Connection = conn;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Record r = new Record();
                r.Artist = (string)reader["Artist"];
                r.Description = (string)reader["Description"];
                r.Genre = (string)reader["Genre"];
                r.RecordId = (int)reader["RecordId"];
                r.Price = (Decimal)reader["Price"];
                r.ImageUrl = (string)reader["ImageUrl"];
                r.ImageThumbnailUrl = (string)reader["ImageThumbnailUrl"];
                r.isPreferredGenre = (string)reader["isPreferredGenre"];
                r.Name = (string)reader["Name"];
                list.Add(r);
            }

            return Json(list);
        }
    }
}