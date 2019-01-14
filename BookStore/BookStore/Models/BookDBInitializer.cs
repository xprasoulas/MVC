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
            base.Seed(context);
        }
    }
}