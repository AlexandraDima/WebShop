using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;
using System.Linq;
using System.Web.Mvc;


namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        //Pass the cart object created in CartModelBinder as parameter values
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                //In the begining we were using the GetCart method to store and manage the cart
                //Cart = GetCart(),

                //Model binder will provide the controller with Cart objects
                Cart = cart,
                ReturnUrl = returnUrl
            });
        } ///End Index view result

        //Pass the cart object created in CartModelBinder as parameter values
        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                //Model binder will provide the controller with Cart objects
                cart.AddItem(product, 1); //add one quantity of this product }
            }
           
            return RedirectToAction("Index", new { controller = returnUrl.Substring(1) });
        }//End public RedirectRoute

        //Pass the cart object created in CartModelBinder as parameter values
        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
         {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                //Model binder will provide the controller with Cart objects
                cart.RemoveItem(product);
            }
            return RedirectToAction("Index", new { controller = "Cart" });
         }//End public RedirectRoute


        //add a widget in the top right that summarizes the contents of the cart 
        // Render a partial view that has the Cart object parameter-which is coming from the custom CartModelBinder
        public PartialViewResult Summary(Cart cart) 
        {
            return PartialView(cart);
        }

        //Define the Checkout method 
        //The Checkout method returns the default view and passes a new ShippingDetails object as the view model
        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }
        //Checkout method
        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            { // order processing logic 
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }
    }
}