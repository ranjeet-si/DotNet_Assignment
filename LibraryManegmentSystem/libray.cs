using System;
using System.Collections.Generic;

namespace LibraryManegmentSystem
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBookInLibrary()
        {
           Console.WriteLine("Enter the number of books to add:");
    int totalBook = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < totalBook; i++)
    {
        Console.WriteLine("Enter the Book Title:");
        string title = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the Book Author:");
        string author = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the Book Genre:");
        string genre = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the Book Quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Book bk = new Book(title, author, genre, quantity);
        books.Add(bk);
    }
    Console.WriteLine();
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book SearchBookByTitle(string title)
        {
            return books.Find(book => book.title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public Book SearchBookByAuthor(string author)
        {
            return books.Find(book => book.author.Equals(author, StringComparison.OrdinalIgnoreCase));
        }
    }
}
