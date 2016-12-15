using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace shelbysBible
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "LoadNothingRedirect",
                url: "load",
                defaults: new { controller = "Home", action = "LoadRedirect"}
            );

            routes.MapRoute(
                name: "LoadBookRedirect",
                url: "load/{book}",
                defaults: new { controller = "Home", action = "LoadRedirect", book = "" }
            );

            // full postback
            routes.MapRoute(
                name: "LoadBookAndChapter",
                url: "load/{book}/{chapter}",
                defaults: new { controller = "Home", action = "Load", book = "", chapter = "" }            
            );

            // ajax partial request
            routes.MapRoute(
                name: "LoadBookAndChapterPartial",
                url: "loadpartial/{book}/{chapter}",
                defaults: new { controller = "Home", action = "LoadPartial", book = "", chapter = "" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
