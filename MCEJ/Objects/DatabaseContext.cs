using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MCEJ.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCEJ.Objects
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
