using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    public class Requests
    {
        public LibraryManager libraryManager;


        //Add book
        public void AddBook (string title, string author, string description, string pages)
        {
            Book book = new Book(title, author, description, pages);

            string json = JsonConvert.SerializeObject(book);

            HttpClient client = new HttpClient();

            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

           // httpClient.PostAsync("https://localhost:7072/api/Book/AddBook");

        }


        //Get all books from database
        public List<Book> GetAllBooks()
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

    }
}
