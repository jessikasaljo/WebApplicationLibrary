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

        public bool AddBook(Book book)
        {
            if (book.Title== "")
            {
                return false;
            }
            // If we make any changes, like adding something new,
            // we must run SaveChanges to save it to the database.
            DB.Books.Add(book);
            DB.SaveChanges();
            return true;
        }
    }
}
