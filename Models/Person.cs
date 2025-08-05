using System;
using System.Collections.Generic;
using System.Linq;
using CALibraryManagementSystem.Models; 

namespace CALibrary.Models
{
    public abstract class Person
    {
        protected static int _nextUserId = 1;
        protected static int _nextLibrarianId = 1;

        public abstract int Id { get; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }

        public Person(string name, string email, string? phone, string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
        }

        public void DisplayAllBooks(Library library)
        {
            var books = library.GetAllBooks();

            if (!books.Any())
            {
                Console.WriteLine("The library is currently empty.");
            }
            else
            {
                Console.WriteLine("\n--- All Books in the Library ---\n");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nEmail: {Email}\nPhone: {Phone ?? "No Phone Number"}";
        }
    }
}