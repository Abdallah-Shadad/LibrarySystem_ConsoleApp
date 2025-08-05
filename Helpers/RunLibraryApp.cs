using CALibrary.Helpers;
using CALibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALibraryManagementSystem.Helpers
{
    public class RunLibraryApp
    {
        public static void Start()
        {
            var authenticator = new AuthenticateUser();

            while (true)
            {
                Person loggedInPerson = authenticator.RunAuthentication();

                switch (loggedInPerson)
                {
                    case null:
                        return;

                    case Librarian librarian:
                        Console.Clear();
                        LibrarianMenu.DisplayLibrarianMenu(librarian);
                        break;

                    case User user:
                        Console.Clear();
                        UserMenu.DisplayUserMenu(user);
                        break;
                }
            }
        }
    }
}
