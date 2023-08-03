﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManegmentSystem
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int quantity { get; set; }

        public Book(string title, string author, string genre, int quantity)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.quantity = quantity;
        }
    }
}
