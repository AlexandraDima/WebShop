using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.ViewModels;
namespace MbmStore.ViewModels
{
    public class CartLine
    {
        /// to represent a product selected by the customer and the quantity the user wants to buy
        public Product Product { get; set; }
        public int Quantity { get; set; }
    } ///end public class CartLine
}