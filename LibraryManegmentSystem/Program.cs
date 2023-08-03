using System;

namespace LibraryManegmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBookInLibrary();

            Console.WriteLine("List of Books in the Library:");
            foreach (Book book in library.GetBooks())
            {
                Console.WriteLine($"{book.title}, {book.author}, {book.genre}, Quantity: {book.quantity}");
            }

            Console.WriteLine("\nEnter the title to search for a book:");
            string searchTitle = Console.ReadLine();
            Book foundBook = library.SearchBookByTitle(searchTitle);
            if (foundBook != null)
            {
                Console.WriteLine($"Book found: {foundBook.title}, {foundBook.author}, {foundBook.genre}, Quantity: {foundBook.quantity}");
            }
            else
            {
                Console.WriteLine($"Book with title '{searchTitle}' not found.");
            }

            Console.WriteLine("\nEnter the author to search for a book:");
            string searchAuthor = Console.ReadLine();
            foundBook = library.SearchBookByAuthor(searchAuthor);
            if (foundBook != null)
            {
                Console.WriteLine($"Book found: {foundBook.title}, {foundBook.author}, {foundBook.genre}, Quantity: {foundBook.quantity}");
            }
            else
            {
                Console.WriteLine($"Book by author '{searchAuthor}' not found.");
            }
        }
    }
}
