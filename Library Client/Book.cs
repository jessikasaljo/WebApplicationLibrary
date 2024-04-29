using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    public class Book
    {
        public int BookId { get; set; }
        
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Pages { get; set; }

        public Book(string title, string author, string description, string pages)
        {

            Title = title;
            Author = author;
            Description = description;
            Pages = pages;
        }
    }
}
