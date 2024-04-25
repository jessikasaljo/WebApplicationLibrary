using MCEJ.Objects;
using MCEJ.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MCEJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        BookService bookService;
        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }


        [HttpPost]
        public ActionResult Addbook(Book book)
        {
            bool requestAccepted = bookService.AddBook(book);
            if (requestAccepted)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
