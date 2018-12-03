using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//added for entity framework error fix
using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models
{
    public class Record
    {
        [Key] //entity framework primary keygen
        //record ID
        public int RecordId { get; set; }

        //record genre
        public string Genre { get; set; }

        //name of record
        public string Name { get; set; }

        //artist of record
        public string Artist { get; set; }

        //record description
        public string Description { get; set; }

        //record price
        public decimal Price { get; set; }

        //image location for record 
        public string ImageUrl { get; set; }

        //image location for thumbnail image 
        public string ImageThumbnailUrl { get; set; }

        //boolean for selected genre
        public bool isPreferredGenre { get; set; }
        
        //set category id for relationships
        //public int CategoryId { get; set; }
        //public virtual Category Category { get; set; }
    }
}
