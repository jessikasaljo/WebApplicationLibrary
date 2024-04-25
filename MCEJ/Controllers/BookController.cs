﻿using MCEJ.Objects;
using MCEJ.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MCEJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
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
