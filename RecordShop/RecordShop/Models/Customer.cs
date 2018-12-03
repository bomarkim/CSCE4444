using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//added for entity framework error fix
using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models
{
    public class Customer
    {
        [Key] //entity framework primary keygen
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public string FavGenre{ get; set; }
    }
}
