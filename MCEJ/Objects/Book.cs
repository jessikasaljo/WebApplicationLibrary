﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MCEJ.Objects
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int BookId { get; set; }
        [Required]
        [MaxLength(50)]

       
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

        public Book() { }
    }
}
