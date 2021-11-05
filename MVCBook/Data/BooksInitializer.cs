using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using MVCBook.Models;

namespace MVCBook.Data
{
    public class BooksInitializer : DropCreateDatabaseAlways<BookDBContext>
    {
        protected override void Seed(BookDBContext context)
        {
            var books = new List<Book>
            { new Book
                {
                    Name = "Professional",
                    Author = "Downey, Robert",
                    PagesNumber = 166,
                    Publisher = "Salamanca",
                    PublicationDate = "2002-05-01",
                    Content = "How to become a professional at anything and everything",
                    Price = 100,
                    PriceConfirm = 100
                } 
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
        }
    }
}