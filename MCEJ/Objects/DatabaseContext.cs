using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MCEJ.Services;

namespace MCEJ.Objects
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("The great Gatsby", "F. Scott Fitzgerald", "Nice book", "300"));
            

            return books;
        }

       
    }
}
