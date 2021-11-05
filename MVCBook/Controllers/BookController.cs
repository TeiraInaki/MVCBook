using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCBook.Models;
using MVCBook.Data;
using System.Data.Entity;

namespace MVCBook.Controllers
{
    public class BookController : Controller
    {

        private BookDBContext context = new BookDBContext();

        // GET: Book
        public ActionResult Index()
        {
            var books = context.Books.ToList();
            return View("Index", books);
        }

        //Insercion en 2 partes
        public ActionResult Create()
        {
            Book book = new Book();

            return View("Create", book);
        }

        //2da parte de Insercion (post)
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", book);
        }
    }
}