using System;

namespace CALibrary.Models
{
    public class Book
    {
        public string ISBN { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string isbn, string title, string author, string genre, int publicationYear)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Genre = genre;
            PublicationYear = publicationYear;
            IsAvailable = true;
        }

        public override string ToString()
        {
            string status = IsAvailable ? "Available" : "Checked Out";
            return $"[\n  Title: {Title}\n  Author: {Author}\n  Genre: {Genre}\n  Year: {PublicationYear}\n  ISBN: {ISBN}\n  Status: {status} \n]";
        }
    }
}
