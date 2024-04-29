using MCEJ.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    public class LibraryManager
    {
        //Get all books from database
        List<Book> GetAllBooks()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync("https://localhost:7072/api/book").Result;
            //Console.WriteLine($"Status code: {response.StatusCode}\r\n");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Book>>(json);
            }
            return null;
        }

        public void DisplayAllBooks()
        {
            List<Book> books = GetAllBooks();
            if (books == null)
            {
                Console.WriteLine("Something went wrong!");
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

            sender.Addbook(newTitle, newAuthor, newDescription, newPages);


        }

    }
}
