using MCEJ.Objects;

namespace MCEJ.Services
{
    public class BookService
    {


        DatabaseContext DB;

        public BookService(DatabaseContext DB)
        {
            this.DB = DB;
        }

        public List<Book> GetBooks()
        {
            return this.DB.GetBooks();
        }

        public Book GetBooksById(int id)
        {
            return DB.Books.Find(id);
        }

    }
}
