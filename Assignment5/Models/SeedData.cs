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
            BookListContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookListContext>();

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
                        Price = 9.95
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
                        Price = 21.54
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
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
