using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogController : Controller
    {
        public int PageSize = 4; //it specifies that we want 4 products per page
        ///update the Catalogue controller so that the Index action method will filter Product objects by category
        // GET: Catalog
        public ActionResult Index(string category, int page = 1) //display the first page of the products
        {
            //update the Index action method to use the ProductsListViewModel class to provide the view with details of the products 
            //and the details of the pagination
          
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = Repository.Products
                //Update the Catalog so that the Index action will filter the Product objects
                .Where(p => category == null || p.Category == category)  //If category is not null, only those Product objects with a matching Category property are selected
                .OrderBy(p => p.ProductId) //Get the product objects and order them by ProductId
                .Skip((page - 1) * PageSize) //Skip over the products thta occur before the start of the current page 
                .Take(PageSize), //Take the number of products specified by the PageSize field

                //Adding the PagingInfo method to diplay the details of the pagination
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    Repository.Products.Count() :  
                    Repository.Products.Where(e => e.Category == category).Count() //the pagination information takes the categories into account
                },
                CurrentCategory = category //set the value of the CurrentCategory property we added to the ProductsListViewModel class
            };
          

            //the View method takes the ProductsListViewModel as parameter 
            //this is the view model class that provides the Catalogue view with the details of the products
            return View(model);


        }

    }
}
