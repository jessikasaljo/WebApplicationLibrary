using Newtonsoft.Json;

namespace Library_Client
{
    public class LibraryManager
    {
        //Fields
        public Menu menu;
        public Requests requests;
      

        //Display all books
        public void DisplayAllBooks()
        {
            List<Book> books = requests.GetAllBooks();
            if (books == null)
            {
                Console.WriteLine("Something went wrong");
            }
            else
            {
                foreach (Book book in books)
                {
                    Console.WriteLine($"Title: {book.Title}\r\n" +
                                      $"Author: {book.Author}\r\n" +
                                      $"Pages: {book.Pages}\r\n" +
                                      $"Description: {book.Description}\r\n");
                }
            }
        }


        //Get book by id?


        public void AddNewBook()
        {
            

            Console.WriteLine("Title: ");
             string newTitle = Console.ReadLine();

            Console.WriteLine("Author: ");
             string newAuthor = Console.ReadLine();

            Console.WriteLine("Description: ");
             string newDescription = Console.ReadLine();

            Console.WriteLine("Number of pages: ");
             string newPages = Console.ReadLine();

            requests.AddBook(newTitle, newAuthor, newDescription, newPages);


        }

    }
}
