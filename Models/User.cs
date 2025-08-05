using CALibraryManagementSystem.Models;
using System;
using System.Collections.Generic;

namespace CALibrary.Models
{
    public class User : Person
    {
        private static int _nextUserId = 1;
        private readonly int _userId;
        public override int Id { get { return _userId; } }

        public string Address { get; set; }
        private List<Book> borrowedBooks = new List<Book>();

        public User(string name, string email, string phone, string password, string address = "")
            : base(name, email, phone, password)
        {
            _userId = _nextUserId++;
            Address = address;
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                borrowedBooks.Add(book);
                Console.WriteLine($"{Name} successfully borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                book.IsAvailable = true;
                borrowedBooks.Remove(book);
                Console.WriteLine($"{Name} returned '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"You have not borrowed '{book.Title}'.");
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.Clear();
            Console.WriteLine("==== Your Borrowed Books ====\n");
            if (borrowedBooks.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have no borrowed books.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (var book in borrowedBooks)
                {
                    Console.WriteLine(book);
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public void SearchBook(string isbn, Library library)
        {
            library.Search(isbn);
        }
    }
}
