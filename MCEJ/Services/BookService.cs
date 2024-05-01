﻿using MCEJ.Objects;

namespace MCEJ.Services
{
    public class BookService
    {

        DatabaseContext DB;

        public BookService(DatabaseContext DB)
        {
            this.DB = DB;
        }

        public List<Book> GetBooks()
        {
            return DB.GetBooks();
        }

        public Book GetBookById(int id)
        {
            return DB.Books.Find(id);
        }

        public bool AddBook(Book book)
        {
            if (book.Title == "")
            {
                return false;
            }

            DB.Books.Add(book);
            DB.SaveChanges();
            return true;
        }

        public bool UpdateCar(Book book)
        {
            Book bookToUpdate = DB.Books.Find(book.BookId);

            if (bookToUpdate == null)
            {
                return false;
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Pages = book.Pages;

            DB.SaveChanges();
            return true;
        }

        public bool DeleteBook(Book book)
        {
            Book bookToDelete = DB.Books.Find(book.BookId);
            if (bookToDelete == null)
            {
                return false;
            }
            DB.Books.Remove(bookToDelete);
            DB.SaveChanges();
            return true;
        }
    }
}
