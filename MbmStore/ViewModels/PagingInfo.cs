using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.ViewModels;
using MbmStore.Models;
//To support the HTML helper, we will pass information to the view about the number of pages available, 
//the current page, and the total number of products in the repository
namespace MbmStore.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}