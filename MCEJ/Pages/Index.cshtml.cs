using MCEJ.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MCEJ.Pages
{
    public class IndexModel : PageModel
    {
        //Fields
        public List<Book> books { get; set; }
        readonly ILogger<IndexModel> _logger;
        readonly DatabaseContext _databaseContext;


        //Constructor
        public IndexModel(ILogger<IndexModel> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }


        //On Get
        public void OnGet()
        {

        }
    }
}
