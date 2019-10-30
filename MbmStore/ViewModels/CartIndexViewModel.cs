using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.ViewModels;

namespace MbmStore.ViewModels
{
    public class CartIndexViewModel
    { 
        //properties 
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}