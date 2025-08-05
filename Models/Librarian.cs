using System;
using CALibraryManagementSystem.Models;

namespace CALibrary.Models
{
    public class Librarian : Person
    {
        private readonly int _librarianId;
        public override int Id { get { return _librarianId; } }

        public double Salary { get; set; }

        public Librarian(string name, string email, string phone, string password, double salary)
            : base(name, email, phone, password)
        {
            if (salary <= 0)
                throw new ArgumentException("Salary must be a positive value.");

            _librarianId = _nextLibrarianId++;
            Salary = salary;
        }

        // This method now takes a Library object as a parameter.
        public void AddBook(Book book, Library library)
        {
            library.Add(book);
        }

        // This method now takes a Library object as a parameter.
        public void RemoveBook(string isbn, Library library)
        {
            library.Remove(isbn);
        }
    }
}