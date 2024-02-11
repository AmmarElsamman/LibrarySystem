using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book
                {
                    ISBN = "1243123232323",
                    Title = "Mountain is you",
                    Price = 50,
                    Quantity = 12
                },
                new Book
                {
                    ISBN = "1243125555555",
                    Title = "can't hurt me",
                    Price = 30,
                    Quantity = 10
                }

            };
            return View(books);
        }
    }
}
