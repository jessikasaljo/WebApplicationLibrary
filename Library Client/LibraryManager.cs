using Newtonsoft.Json;
using System.Reflection;

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
                    Console.WriteLine($"ID: {book.BookId}\r\n" +
                                      $"Title: {book.Title}\r\n" +
                                      $"Author: {book.Author}\r\n" +
                                      $"Pages: {book.Pages}\r\n" +
                                      $"Description: {book.Description}\r\n");
                }
            }
        }


        //Add new book
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


        //Edit book
        public void UpdateBook()
        {
            DisplayAllBooks();

            Console.WriteLine("\nWrite the id of the book you want to edit.");
            int id;
            try
            {
                id = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("That was not a number.");
                return;
            }
             

            BookExists(id);

            Console.Clear();
            Console.WriteLine("Input new title.");
            string title = Console.ReadLine();
            Console.WriteLine("Input new author.");
            string author = Console.ReadLine();
            Console.WriteLine("Input new description.");
            string description = Console.ReadLine();
            Console.WriteLine("Input new number of pages.");
            string pages = Console.ReadLine();

            // Anropa EditBook-metoden för att redigera boken
            requests.EditBook(id, title, author, description, pages);
        }


        //Checks if book exists
        private bool BookExists(int id)
        {
            List<Book> books = requests.GetAllBooks();

            foreach (var book in books)
            {
                if (book.BookId == id)
                {
                    return true;
                }
            }
            return false;
        }


        //Delete book
        public void DeleteBook()
        {
            DisplayAllBooks();

            Console.WriteLine("\nInput id of the book to delete.");
            int id;
            try
            {
                id = int.Parse(Console.ReadLine());
                requests.DeleteBook(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("That was not a number.");
                return;
            }
        }
    }
 }

