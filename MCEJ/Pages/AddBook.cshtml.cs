using MCEJ.Objects;
using MCEJ.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MCEJ.Pages
{
    public class AddBookModel : PageModel
    {
        readonly ILogger<AddBookModel> _logger;

        public Book book; 

        readonly DatabaseContext _databaseContext;

        BookService _bookService;

        List<Book> books;



        

        [BindProperty]
        public string Message { get; set; }

        public AddBookModel(ILogger<AddBookModel> logger, DatabaseContext databaseContext, BookService bookService)
        {
            _bookService = bookService;
            _logger = logger;
            _databaseContext = databaseContext;

        }

        public void OnGet()
        {
        }

        public void OnPost(Book book)
        {
            if (!ModelState.IsValid)
            {
                _databaseContext.Books.Add(book);
                _databaseContext.SaveChanges();

            }

            books = _databaseContext.Books.ToList();

        
        }
    }
  
    
}
