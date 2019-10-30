using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.Models
{
    public class Invoice
    {
        // Fields
        private decimal totalPrice;
        List<OrderItem> orderItems = new List<OrderItem>();
      
        // Properties
        public decimal TotalPrice
        {
            get {
                // Calculate the totalprice, for each order in the list.            
                decimal price = 0M;
                foreach (var order in OrderItems)
                {
                    price += order.Product.Price * order.Quantity;
                }
                return price;
            }

        }

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

      
        public int InvoiceId
        {
            get;
            set;
        }

        public DateTime OrderDate
        {
            get;
            set;
        }

        public Customer Customer
        {
            get;
            set;
        }

        // Constructor
        // Used for creating the Invoice objects

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
        }

        // Void method helps adding objects to a list.
        public void addOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

       
        

    }
}