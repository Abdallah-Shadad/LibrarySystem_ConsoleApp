using CALibrary.Models;
using CALibrary.Helpers;
using CALibraryManagementSystem.Helpers;

namespace CALibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOHelperMethods.DisplayWelcomeMessage();
            RunLibraryApp.Start();
            IOHelperMethods.DisplayGoodbyeMessage();
        }
    }
}