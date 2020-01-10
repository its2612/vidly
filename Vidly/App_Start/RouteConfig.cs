using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("byMovie", "Movies/Randoms", new { Controller = "Movies", Action = "Random", id = UrlParameter.Optional });


            routes.MapRoute("ByDate","Movies/ByReleased/{month}/{year}",
                new {Controller="Movies",Action="byreleasedate" },new {month=@"\d{2}",year= @"\d{4}" });

            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
