using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        //AuthorMiddle = "",
                        Publisher= "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        PageLength = 1488
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        //AuthorMiddle = "",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        PageLength = 832
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorLast = "Goodwin",
                        AuthorMiddle = "Kearns",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        PageLength = 944
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorLast = "White",
                        AuthorMiddle = "C.",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        PageLength = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        PageLength = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        PageLength = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        PageLength = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        PageLength = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        PageLength = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        PageLength =642
                    },
                    new Book
                    {
                        Title = "When Breath Becomes Air",
                        AuthorFirst = "Paul",
                        AuthorLast = "Kalanithi",
                        Publisher = "Random House",
                        ISBN = "978-0812988406",
                        Classification = "Non-Fiction",
                        Category = "Autobiography",
                        Price = 26.00,
                        PageLength = 256
                    },
                    new Book
                    {
                        Title = "The Way of Kings",
                        AuthorFirst = "Brandon",
                        AuthorLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 23.64,
                        PageLength = 1005
                    },
                    new Book
                    {
                        Title = "The Boy, the Mole, the Fox and the Horse",
                        AuthorFirst = "Charlie",
                        AuthorLast = "Mackesy",
                        Publisher = "HarperCollins Publishers",
                        ISBN = "978-0062976581",
                        Classification = "Fiction",
                        Category = "Illustrated",
                        Price = 14.54,
                        PageLength = 128
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
