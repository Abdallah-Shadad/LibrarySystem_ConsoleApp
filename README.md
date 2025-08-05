CALibrary Management System

Overview

The CALibrary Management System is a console-based application developed in C# using Visual Studio 2022. It allows librarians to manage books (add, remove, view) and users to search, borrow, and return books. The application is structured with separate models, handlers, and helpers for modularity and maintainability.

Features





Librarian Features:





Add a new book with details (ISBN, Title, Author, Genre, Publication Year).



Remove a book by ISBN.



View all books in the library.



User Features:





Search for a book by ISBN.



Borrow and return books.



View borrowed books.



Authentication: Supports Librarian and User roles with registration.

Prerequisites





.NET 7 SDK



Visual Studio 2022 with .NET desktop development workload



Git installed (included with Visual Studio 2022)

Installation





Clone the repository:

git clone https://github.com/your-username/CALibraryManagementSystem.git



Open the solution file (CALibraryManagementSystem.sln) in Visual Studio 2022.



Build the solution (Ctrl+Shift+B) to restore dependencies and compile the project.



Run the application by pressing F5 or selecting "Start Debugging".

Project Structure

CALibraryManagementSystem/
├── CALibrary/
│   ├── Helpers/
│   │   ├── AuthenticateUser.cs
│   │   ├── IOHelperMethods.cs
│   │   ├── LibrarianMenu.cs
│   │   ├── LibraryStorage.cs
│   │   ├── UserMenu.cs
│   ├── Models/
│   │   ├── Book.cs
│   │   ├── Librarian.cs
│   │   ├── Person.cs
│   │   ├── User.cs
│   ├── Handlers/
│   │   ├── LibrarianHandlers.cs
│   ├── Program.cs
├── CALibraryManagementSystem/
│   ├── Helpers/
│   │   ├── RunLibraryApp.cs
│   ├── Models/
│   │   ├── Library.cs
│   │   ├── LibraryCard.cs
├── .gitignore
├── README.md
├── CALibraryManagementSystem.sln

Usage





Run the application.



Choose whether you are a Librarian (L), User (U), or want to Exit (E).



For Librarians:





Add, remove, or view books via the Librarian Menu.



For Users:





Search, borrow, return books, or view borrowed books via the User Menu.

Contributing

Contributions are welcome! Please follow these steps:





Fork the repository.



Create a new branch (git checkout -b feature-branch).



Make your changes and commit (git commit -m "Add feature").



Push to the branch (git push origin feature-branch).



Create a Pull Request.

License

This project is licensed under the MIT License.