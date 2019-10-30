using MbmStore.Models;
using System.Collections.Generic;

//Use a view model because the Catalog view didn't map to a single class in the domain model
//wrap all of the data that connected to the Products, Category and PagingInfo and send it to the Catalogcontroller 
namespace MbmStore.ViewModels

{
    public class ProductsListViewModel
    {
        ///Properties to communicate the products and the current category to the sidebar view
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; } //Communicate the current category to the view in order to render the sidebar
    }
}