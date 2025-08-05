using CALibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CALibraryManagementSystem.Models
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        // Librarian Methods
        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Remove(string isbn)
        {
            Book bookToRemove = FindBookByISBN(isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Book with ISBN {isbn} has been removed.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Error: No book found with ISBN {isbn}.");
            }
        }

        // User Methods
        public void Search(string isbn)
        {
            var searchedBook = FindBookByISBN(isbn);
            if (searchedBook != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-- Book Found :) --\n");
                Console.WriteLine(searchedBook);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"-- Book with ISBN {isbn} Not Found :( --\n");
            }
            Console.ResetColor();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book FindBookByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }
    }
}
