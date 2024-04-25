using MCEJ.Services;
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
    }
}
