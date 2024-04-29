using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    public class LibraryManager
    {
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
