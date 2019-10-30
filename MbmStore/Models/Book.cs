using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book:Product
    {
        // fields - I need fields only when I create my own get and set into the properties     
        // properties - just get and set creates private fields automatically
        public string Author
        {
            get;
            set;
        }

        public string Publisher
        {
            get;
            set;
        }

        public short Published
        {
            get;
            set;
        }

        public string ISBN
        {
            get;
            set;
        }


        // Constructor
        // Used for creating the Book objects
        public Book(){}

        public Book(int productId, string title, string author, decimal price, string publisher, string iSBN, string imageUrl):
        base(productId, title, price, imageUrl)
        {
            this.Author = author;
            this.Publisher = publisher;
            this.ISBN = iSBN;
       
        }
    }
}