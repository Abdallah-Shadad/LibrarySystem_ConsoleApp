using CALibrary.Models;
using CALibraryManagementSystem.Models;


namespace CALibrary.Handlers
{
    public class LibrarianHandlers
    {
        public static void HandleAddBook(Librarian librarian, Library library)
        {
            Console.WriteLine("==== Add a Book ====");
            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            Book existingBook = library.GetAllBooks().FirstOrDefault(b => b.ISBN == isbn);

            if (existingBook != null)
            {
                Console.WriteLine($"Error: A book with ISBN {isbn} already exists. Please use a unique ISBN.");
                return; // Exit the method.
            }

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            int publicationYear = 0;
            while (true)
            {
                Console.Write("Enter Publication Year: ");
                string yearInput = Console.ReadLine();
                if (int.TryParse(yearInput, out publicationYear) && publicationYear > 0) break;
                Console.WriteLine("Invalid year. Please enter a valid number (e.g., 2023).");
            }

            Book newBook = new Book(isbn, title, author, genre, publicationYear);
            librarian.AddBook(newBook, library); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Book with ISBN {newBook.ISBN} has been added successfully!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any button....");
            Console.ReadKey();
        }
        public static void HandleRemoveBook(Librarian librarian, Library library) 
        {
            Console.WriteLine("==== Remove a Book ====");
            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            librarian.RemoveBook(isbn,library);

            Console.WriteLine("Press any button....");
            Console.ReadKey();
        }
        public static void HandleViewAllBooks(Librarian librarian, Library library) 
        {
            Console.WriteLine("==== View All Books ====");
            librarian.DisplayAllBooks(library);

            Console.WriteLine("Press any button....");
            Console.ReadKey();
        }
    }
}
