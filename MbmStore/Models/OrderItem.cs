using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        // Fields
        private decimal totalPrice;
        
        // Properties
        public int OrderItemId
        {
            get;
            set;
        }

        public int ProductId
        {
            get;
            set;
        }

        public Product Product
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public decimal TotalPrice
        {
            get;
           
        }

        // Constructor for OrderItem
        public OrderItem()
        {
        }
        public OrderItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

    }
}