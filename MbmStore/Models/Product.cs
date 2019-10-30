using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Product class is the template that is used to create all the instances/properties of the Product object.  

//Classes inside the ASP.NET framework are organized in namespaces, which are containers used for organizing classes in logical collections
//In this way I can always reference all the classes to MbmStore.Models namespace
namespace MbmStore.Models
{
    //Declaration of class Product
    //The class containes data and methods
    public class Product
    {
        // object fields/instance variables   
    
        private string title;
        private decimal price;


        // properties - just get and set creates private fields automatically
        public string Title
        {
            get { return title; } 
            set { title = value; }                   
        }

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }

        public string ImageUrl
        {
            get;
            set;
        }
        public int ProductId
        {
            get;
            set;
        }

        public string Category { get; set; } //Add a Category property to the Product class and add it to each product from the Repository
        // Constructor
        // Used for creating the Product objects
        public Product()
        {
      
        }


        public Product(int productId, string title, decimal price, string imageUrl)
        {
            this.ProductId = productId;
            this.Title = title;
            this.Price = price;
            this.ImageUrl = imageUrl;
        }

    }
}