using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RecordShop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecordShopContext(
                serviceProvider.GetRequiredService<DbContextOptions<RecordShopContext>>()))
            {
                // Look for any records
                if (context.Record.Any())
                {
                    return;   // DB has been seeded
                }

                context.Record.AddRange(
                    new Record
                    {
                        Name = "A Bucket",
                        Artist = "Some Dude",
                        Genre = "Rock",
                        Price = 7.99M,
                        Description = "This is really just a bucket.",
                        ImageUrl = "https://cdnimg.webstaurantstore.com/images/products/large/221211/1199302.jpg",

                    },

                    new Record
                    {
                        Name = "Music For Supermarkets",
                        Artist = "Jean Michel Jarre",
                        Genre = "Classical",
                        Price = 20000.99M,
                        Description = "A very rare find.",
                        ImageUrl = "https://www.loveantiques.com/user_resources/images/content/Michael%20Jarre%20-%20Music%20For%20Supermarkets.jpg",

                    },

                     new Record
                     {
                         Name = "God Save The Queen",
                         Artist = "Sex Pistols",
                         Genre = "Rock",
                         Price = 12000M,
                         Description = "Onlyy 300 ever printed!",
                         ImageUrl = "https://www.loveantiques.com/user_resources/images/content/Sex%20Pistols%20-%20God%20Save%20The%20Queen.jpg",

                     },

                    new Record
                    {
                        Name = "Please Please Me",
                        Artist = "The Beatles",
                        Genre = "Rock",
                        Price = 7500M,
                        Description = "Only 300 ever printed!",
                        ImageUrl = "https://www.loveantiques.com/user_resources/images/content/please%20please%20me.jpg",

                    }
                );
                context.SaveChanges();
            }
        }
    }
}

