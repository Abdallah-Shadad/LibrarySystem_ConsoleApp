using System;
using CALibrary.Models;
using CALibraryManagementSystem.Handlers;
using CALibraryManagementSystem.Models;

namespace CALibrary.Helpers
{
    public class UserMenu
    {

        public static void DisplayUserMenu(User user)
        {
            var library = LibraryStorage.SharedLibrary;

            while (true)
            {

                Console.Clear();
                Console.WriteLine($"Welcome User {user.Name}\n");
                Console.WriteLine("--- User Menu ---");
                Console.WriteLine("1. Search for a Book");
                Console.WriteLine("2. Borrow a Book");
                Console.WriteLine("3. Return a Book");
                Console.WriteLine("4. View your borrowed books");
                Console.WriteLine("5. Log out");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        UserHandlers.HandleSearchBook(library);
                        break;
                    case "2":
                        UserHandlers.HandleBorrowBook(user, library);
                        break;

                    case "3":
                        UserHandlers.HandleReturnBook(user, library);  
                        break;
                    case "4":
                        Console.WriteLine("Displaying your borrowed books...");
                        user.DisplayBorrowedBooks();
                        break;
                    case "5":
                        Console.WriteLine("Logging out...");
                        return; // Exit the menu method and return to the main loop.
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}