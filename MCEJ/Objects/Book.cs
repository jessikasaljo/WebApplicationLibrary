using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MCEJ.Objects
{
    public class Book
    {
        [Key] //Primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto Increment
        public int BookId { get; set; }
        [Required]
        [MaxLength(50)]

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Pages { get; set; }

        public Book(int bookid, string title, string author, string description, string pages)
        {
            BookId = bookid;
            Title = title;
            Author = author;
            Description = description;
            Pages = pages;
        }

        public Book() { }

        public string GetInfo()
        {
            return "ID: " + Title + ", License Plate: " + Author + ", Model: " + Description + ", Color: " + Pages;
        }

    }
}
