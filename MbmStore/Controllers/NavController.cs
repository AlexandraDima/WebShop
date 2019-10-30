using MbmStore.Infrastructure;
using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class NavController : Controller
    {
        // The Menu action method - renders the navigation menu of the product categories
        // Since the child action returns a partial view to display the data, 
        //we called the Partial view in the action method, that has the category parameter
        public PartialViewResult Menu(string category = null)
        {
            // Assign a SelectedCategory to the ViewBag and set its value to the current category
            // Using Linq query to obtain the list of categories from the repository and pass it to the partial view
            ViewBag.SelectedCategory = category; //the ViewBag allows us to pass data from the controller to the view without using a view model.
            IEnumerable<string> categories = Repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);
            return PartialView(categories);
        }

    }
}