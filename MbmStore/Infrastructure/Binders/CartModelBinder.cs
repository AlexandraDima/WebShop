using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;
using System.Web.Mvc;
using MbmStore.ViewModels;
//Creating a model binder (BindModel)that obtains the Cart object contained in the session data
//MVC will be able to create Cart objects and pass them as parameters to the action methods in the CartController
namespace MbmStore.Infrastructure.Binders
{
    public class CartModelBinder: IModelBinder
    {
        private const string sessionKey = "Cart";

        //Method BindModel has 2 required parameters
        //ControllerContext provides access to all the information that the controller class has, including details of the request from the client
        //ModelBindingContext gives us information about the model object and tools for making the binding process easier
        public object BindModel(System.Web.Mvc.ControllerContext controllerContext, ModelBindingContext bindingContext)
        { 
        Cart cart = null;
            //The most important is the controllerContext- has an HTTPContext property that gets and sets session data
            //the session helps to store and manage the Cart objects
            if (controllerContext.HttpContext.Session != null) 
        {
            //Obtain the Cart object associated with the user's session by reading the value of the session
            cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
        }
            // create the Cart if there wasn't one in the session data 
          
            if (cart == null)
        {
            cart = new Cart();

            if (controllerContext.HttpContext.Session != null)
            {
                controllerContext.HttpContext.Session[sessionKey] = cart;
            }
         }
            // return the cart 
            return cart;
        }
    }
}