using CALibrary.Models;
using System;

namespace CALibrary.Helpers
{
    public class AuthenticateUser
    {
        public Person RunAuthentication()
        {
            while (true)
            {
                Console.Write("\nAre you Librarian or User (L/U) or Exit (E): ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "l":
                    case "librarian":
                        return CreateLibrarian(); 

                    case "u":
                    case "user":
                        return CreateUser(); 

                    case "e":
                    case "exit":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return null;

                    default:
                        Console.WriteLine("Not a valid choice. Please try again.");
                        break;
                }
            }
        }



        // Helper method to create a Librarian object
        private static Librarian CreateLibrarian()
        {
            Console.Clear();
            Console.WriteLine("--- New Librarian Registration ---");
            (string name, string email, string phone, string password) commonDetails = IOHelperMethods.GetCommonPersonDetails();

            double salary = 0;
            while (true)
            {
                Console.Write("Enter Salary: ");
                string salaryInput = Console.ReadLine();
                if (double.TryParse(salaryInput, out salary))
                {
                    break;
                }
                Console.WriteLine("Invalid salary format. Please enter a number.");
            }

            return new Librarian(
                commonDetails.name,
                commonDetails.email,
                commonDetails.phone,
                commonDetails.password,
                salary
            );
        }

        // Helper method to create a User object
        private static User CreateUser()
        {
            Console.Clear();
            Console.WriteLine("--- New User Registration ---");
            (string name, string email, string phone, string password) commonDetails = IOHelperMethods.GetCommonPersonDetails();

            Console.Write("Enter Address (optional): ");
            string userAddress = Console.ReadLine();

            return new User(
                commonDetails.name,
                commonDetails.email,
                commonDetails.phone,
                commonDetails.password,
                userAddress
            );
        }

    }
}