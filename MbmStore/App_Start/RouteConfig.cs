using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MbmStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "null",
                url: "{controller}",
                defaults: new { controller = "Catalog", action = "Index", category = (string)null, page = 1}
            );
            routes.MapRoute(
                name: null, 
                url: "{controller}/Page{page}", 
                defaults: new { controller = "Catalog", action = "Index", category = (string)null }, 
                constraints: new { page = @"\d+" }
            );
            routes.MapRoute(
                name: null, 
                url: "Catalog/{category}", 
                defaults: new { controller = "Catalog", action = "Index", page = 1}
            );

            routes.MapRoute(
                name: null, 
                url: "{controller}/{category}/Page{page}", 
                defaults: new { controller = "Catalog", action = "Index" },
                constraints: new { page = @"\d+" }
             );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Catalog",
                    action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
