CALibrary Management System
Overview
The CALibrary Management System is a console-based application developed in C# using Visual Studio 2022. It enables librarians to manage books (add, remove, view) and allows users to search, borrow, and return books. The application is designed with modularity and maintainability in mind, utilizing separate Models, Handlers, and Helpers folders.
Features
Librarian Features

Add a new book with details (ISBN, Title, Author, Genre, Publication Year).
Remove a book by ISBN.
View all books in the library.

User Features

Search for a book by ISBN.
Borrow and return books.
View borrowed books.

Authentication

Supports Librarian and User roles with registration.

Prerequisites

.NET 7 SDK
Visual Studio 2022 with .NET desktop development workload
Git installed (included with Visual Studio 2022)

Installation

Clone the repository:git clone https://github.com/Abdallah-Shadad/LibrarySystem_ConsoleApp.git


Open the solution file (CALibraryManagementSystem.sln) in Visual Studio 2022.
Build the solution (Ctrl+Shift+B) to restore dependencies and compile the project.
Run the application by pressing F5 or selecting "Start Debugging".

Usage

Run the application.
Choose your role:
Librarian (L)
User (U)
Exit (E)


For Librarians:
Add, remove, or view books via the Librarian Menu.


For Users:
Search, borrow, return books, or view borrowed books via the User Menu.



Contributing
Contributions are welcome! Please follow these steps:

Fork the repository.
Create a new branch:git checkout -b feature-branch


Make your changes and commit:git commit -m "Add feature"


Push to the branch:git push origin feature-branch


Create a Pull Request on GitHub.

License
This project is licensed under the MIT License.
