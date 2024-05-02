using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Client
{
    public class Requests
    {
        //Fields
        public LibraryManager libraryManager;


        //Add book
        public void AddBook (int id, string title, string author, string description, string pages)
        {
            Book book = new Book(id, title, author, description, pages);

            string json = JsonConvert.SerializeObject(book);

            HttpClient client = new HttpClient();

            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");


            HttpResponseMessage response = client.PostAsync("https://localhost:7072/api/Book/AddBook", httpContent).Result;


            Console.WriteLine("Status code: " + response.StatusCode);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(title + " successfully added!");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }

        }


        //Get all books from database
        public List<Book> GetAllBooks()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync("https://localhost:7072/api/book").Result;

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Book>>(json);
            }
            return null;
        }


        //Edit book
        public void EditBook(int id, string title, string author, string description, string pages)
        {
            Book book = new Book(id, title, author, description, pages);
            string json = JsonConvert.SerializeObject(book);

            HttpClient client = new HttpClient();
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"https://localhost:7072/api/book/editBook?id={id}", httpContent).Result;
            Console.WriteLine("Status code: " + response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Book successfully edited!");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }

        public void DeleteBook(int id)
        {
            string url = $"https://localhost:7072/api/book/deleteBook?id={id}";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.DeleteAsync(url).Result;

            Console.WriteLine("Status code: " + response.StatusCode);
            
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Book successfully deleted.");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }

    }
}
