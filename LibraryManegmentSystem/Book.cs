using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegmentSystem
{
    public class Book
    {
 
        
            private string title;
            private string author;
            private string genre;
            private int quantity;
     

          
            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Author
            {
                get { return author; }
                set { author = value; }
            }

            public string Genre
            {
                get { return genre; }
                set { genre = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

          
            public Book(string title, string author, string genre, int quantity)
            {
                Title = title;
                Author = author;
                Genre = genre;
                Quantity = quantity;
            }

         


            
           
        }


 }

