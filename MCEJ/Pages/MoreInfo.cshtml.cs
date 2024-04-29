using MCEJ.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace MCEJ.Pages
{
    public class ViewBooksModel : PageModel
    {
        //Fields
        public List<Book> books { get; set; }
        readonly ILogger<ViewBooksModel> _logger;
        readonly DatabaseContext _databaseContext;


        //Constructor
        public ViewBooksModel(ILogger<ViewBooksModel> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }


        //On Get
        public void OnGet()
        {
            books = _databaseContext.Books.ToList();
        }
    }
}
