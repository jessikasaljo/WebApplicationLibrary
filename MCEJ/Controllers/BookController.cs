using MCEJ.Objects;
using MCEJ.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MCEJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // Detta är API:t

        // Endast GET fungerar på webbsidan om man inte har gjort en form till den, då fungerar även POST. För att testa PUT och DELETE måste
        //man använda Postman eller Swagger.

        BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        
        [HttpGet]
        public List<Book> GetBooks()
        {
            return bookService.GetBooks();
        }

        [HttpGet("ById")]
        public Book GetBook(int id)
        {
            return bookService.GetBookById(id);
        }


        [HttpPost("AddBook")]
        public ActionResult Addbook(Book book)
        {
           
            bool requestAccepted = bookService.AddBook(book);
            if (requestAccepted)
            {
                return Ok();
            }
            return BadRequest();
        }


        [HttpPut("EditBook")] 
        public ActionResult Editbook(Book book)
        {
            bool success = bookService.UpdateCar(book);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("DeleteBook")]
        public ActionResult DeleteBook(Book book)
        {
            bool success = bookService.DeleteBook(book);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

       
    }
}
