using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        // GET
        public string Index()
        {
            return "This is the book index.";
        }

        public string Details()
        {
            return "This is the details of a book.";
        }
    }
}