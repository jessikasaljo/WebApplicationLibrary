using MCEJ.Objects;
using MCEJ.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Numerics;

namespace MCEJ.Pages
{
    public class MoreInfoModel : PageModel
    {
        //Fields
        public Book book;
        public List<Book> books { get; set; }
        readonly ILogger<MoreInfoModel> _logger;
        readonly DatabaseContext _databaseContext;
        BookService _bookService;


        //Constructor
        public MoreInfoModel(ILogger<MoreInfoModel> logger, DatabaseContext databaseContext, BookService bookService)
        {
            _logger = logger;
            _databaseContext = databaseContext;
            _bookService = bookService;
        }


        //On Get
        public IActionResult OnGet(int id)
        {
            book = _bookService.GetBookById(id);
            if (book == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
