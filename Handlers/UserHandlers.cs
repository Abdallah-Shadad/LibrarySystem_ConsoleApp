using CALibrary.Models;
using CALibraryManagementSystem.Models;
using System;

namespace CALibraryManagementSystem.Handlers
{
    public class UserHandlers
    {
        public static void HandleSearchBook(Library library)
        {
            Console.Clear();
            Console.WriteLine("==== Searching for a Book ====");
            Console.Write("Enter Book ISBN: ");
            string isbn = Console.ReadLine();

            library.Search(isbn);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void HandleBorrowBook(User user, Library library)
        {
            Console.Clear();
            Console.WriteLine("==== Borrow a Book ====");
            Console.Write("Enter Book ISBN: ");
            string isbn = Console.ReadLine();

            Book book = library.FindBookByISBN(isbn);
            if (book != null)
            {
                user.BorrowBook(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void HandleReturnBook(User user, Library library)
        {
            Console.Clear();
            Console.WriteLine("==== Return a Book ====");
            Console.Write("Enter Book ISBN: ");
            string isbn = Console.ReadLine();

            Book book = library.FindBookByISBN(isbn);
            if (book != null)
            {
                user.ReturnBook(book);
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
