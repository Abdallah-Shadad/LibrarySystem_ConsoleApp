using System;
using System.Linq;
using CALibrary.Models;
using CALibraryManagementSystem.Models;
using CALibrary.Handlers;

namespace CALibrary.Helpers
{
    public class LibrarianMenu
    {
        public static void DisplayLibrarianMenu(Librarian librarian)
        {
            var library = LibraryStorage.SharedLibrary;

            Console.WriteLine($"Welcome Librarian {librarian.Name}");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Librarian Menu ---");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Remove a Book");
                Console.WriteLine("3. View all Books");
                Console.WriteLine("4. Log out");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        LibrarianHandlers.HandleAddBook(librarian, library); 
                        break;
                    case "2":
                        Console.Clear();
                        LibrarianHandlers.HandleRemoveBook(librarian, library);
                        break;
                    case "3":
                        Console.Clear();
                        LibrarianHandlers.HandleViewAllBooks(librarian, library);
                        break;
                    case "4":
                        Console.WriteLine("Logging out...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

    }
}