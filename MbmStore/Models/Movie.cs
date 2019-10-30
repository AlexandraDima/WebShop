using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie:Product
    {
        private string director;

        // Properties
        // Auto implemented property
        public string Director
        {
            get { return director; } 
            set { director = value; } 
        }

        // Constructor
        // Used for creating the Movie objects
        public Movie(string title, decimal price)
        {
        }

        public Movie(int productId, string title, decimal price, string imageUrl, string director):
        base (productId, title, price, imageUrl)
        {
            this.director = director;
        }
    }
}