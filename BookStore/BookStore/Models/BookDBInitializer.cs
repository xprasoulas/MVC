using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//

namespace BookStore.Models
{
    public class BookDBInitializer : DropCreateDatabaseAlways<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            context.Books.Add(new Book()
            {
                Name = "Teach Yourself C#",
                PublicationDate = new DateTime(2018, 6, 21),
                Price = 45,
                Genre = "Science"
            });
            context.Books.Add(new Book()
            {
                Name = "Programming with C#",
                PublicationDate = new DateTime(2016, 2, 19),
                Price = 32,
                Genre = "IT"
            });
            context.Books.Add(new Book()
            {
                Name = "MVC in ASP.NET",
                PublicationDate = new DateTime(2017, 3, 25),
                Price = 87,
                Genre = "Informatics"
            });
        }
    }
}