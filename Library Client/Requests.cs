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
        public void AddBook (string title, string author, string description, string pages)
        {
            Book book = new Book(title, author, description, pages);

            string json = JsonConvert.SerializeObject(book);

            HttpClient client = new HttpClient();

            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            httpClient.PostAsync("https://localhost:7072/api/Book/AddBook");

        }

    }
}
