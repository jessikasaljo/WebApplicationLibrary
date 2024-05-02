using MCEJ.Objects;

namespace MCEJ.Services
{
    public class BookService
    {
        //Fields
        DatabaseContext DB;


        //Constructor
        public BookService(DatabaseContext DB)
        {
            this.DB = DB;
        }


        //Get all books
        public List<Book> GetBooks()
        {
            return DB.Books.ToList();
        }


        //Get book by id
        public Book GetBookById(int id)
        {
            return DB.Books.Find(id);
        }


        //Add new book
        public bool AddBook(Book book)
        {
            if (book.Title == "")
            {
                return false;
            }

            DB.Books.Add(book);
            DB.SaveChanges();
            return true;
        }


        //Edit book
        public bool UpdateBook(Book book)
        {
            Book bookToUpdate = DB.Books.Find(book.BookId);

            if (bookToUpdate == null)
            {
                return false;
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Pages = book.Pages;

            DB.SaveChanges();
            return true;
        }


        //Delete book
        public bool DeleteBook(int id)
        {
            Book bookToDelete = DB.Books.Find(id);

            if (bookToDelete == null)
            {
                return false;
            }
            DB.Books.Remove(bookToDelete);
            DB.SaveChanges();
            return true;
        }
    }
}
