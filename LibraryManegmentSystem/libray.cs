using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



namespace LibraryManegmentSystem
{
    public class libray
    {
         Book[] booklib;
         int totalBook;


        public void AddBookInLibray()
        {
            Console.WriteLine("Enter the no of Book ");
            totalBook = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalBook; i++)
            {
                booklib = new Book[totalBook];
                Console.WriteLine("Enter the Book Title");
                booklib[i].Title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Book Author");
                booklib[i].Author = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Book Genre");
                booklib[i].Genre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Book Quntity");
                booklib[i].Quantity = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("/n");
        }
        

   }
}
