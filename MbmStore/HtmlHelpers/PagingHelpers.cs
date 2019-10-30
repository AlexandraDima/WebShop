using MbmStore.ViewModels;
using System;
using System.Text;
using System.Web.Mvc;
using MbmStore.Models;
namespace MbmStore.HtmlHelpers
{
    public static class PagingHelpers
    {
        //The PageLinks extension method for the HtmlHelper class that generates the HTML for a set of 
        //page links using the information provided in a PagingInfo object-that it's inside the ViewModel
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, 
        Func<int, string> pageUrl) //The Func parameter accepts a delegate that it uses to generate the links to view other pages
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}