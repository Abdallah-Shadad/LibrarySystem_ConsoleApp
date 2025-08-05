using CALibrary.Models;
using System;

namespace CALibrary.Helpers
{
    public class IOHelperMethods
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("==== Welcome to our Library System ====");
        }

        public static void DisplayGoodbyeMessage()
        {
            Console.WriteLine("\nPress any key to exit the application.");
            Console.ReadKey();
        }

        // Helper method to get the details common to both a Librarian and a User
        public static (string name, string email, string phone, string? password) GetCommonPersonDetails()
        {
            string name = GetRequiredInput("Name");
            string email = GetValidEmail("Email");
            string? phone = GetOptionalInput("Phone");
            string password = GetValidPassword("Password");

            return (name, email, phone, password);
        }

        private static string GetRequiredInput(string fieldName)
        {
            string input;
            do
            {
                Console.Write($"Enter {fieldName}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{fieldName} cannot be empty!");
                    Console.ResetColor();
                }

            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }
        private static string? GetOptionalInput(string fieldName)
        {
            Console.Write($"Enter {fieldName} (optional): ");
            string? input = Console.ReadLine()?.Trim();

            return string.IsNullOrWhiteSpace(input) ? null : input;
        }


        private static string GetValidEmail(string fieldName)
        {
            string input;
            do
            {
                Console.Write($"Enter {fieldName}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || !input.Contains("@"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid email! Must contain '@'.");
                    Console.ResetColor();
                    input = null;
                }

            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        private static string GetValidPassword(string fieldName)
        {
            string input;
            do
            {
                Console.Write($"Enter {fieldName}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.Length < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{fieldName} must be at least 4 characters!");
                    Console.ResetColor();
                    input = null;
                }

            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }
    }
}
