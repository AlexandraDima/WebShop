﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Process for capturing the shipping details from a user
namespace MbmStore.ViewModels
{
    public class ShippingDetails
    {
        ///Properties 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public bool GiftWrap { get; set; }
    }
}