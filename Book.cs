using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public  string bookTitle;
        public  string description;
        public  int quantity;
        public  int remainingQuantity;
        public  string Id;

        public Book(string Id1, string bookTitle1, string description1, int quantity1)
        {
            Id = Id1;
            bookTitle = bookTitle1;
            description = description1;
            quantity = quantity1;
            remainingQuantity = quantity;
        }
        public Book( int id, string bookTitle1, string description1, int quantity1)
        {
            
            Id = id.ToString();
            bookTitle = bookTitle1;
            description = description1;
            quantity = quantity1;
            remainingQuantity = quantity;
        }
    }
}
