using MCEJ.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace MCEJ.Pages
{
    public class ViewBooksModel : PageModel
    {
        private readonly ILogger<ViewBooksModel> _logger;
        private readonly DatabaseContext _databaseContext;
        public List<Book> books { get; set; }

        public ViewBooksModel(ILogger<ViewBooksModel> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        public void OnGet()
        {
            books = _databaseContext.Books.ToList();
        }
    }
}
