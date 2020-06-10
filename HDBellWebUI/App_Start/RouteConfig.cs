using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HDBellWebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                 "EditTicket/{id}",
                 "Edit/{id}",
                 new { controller = "Ticket", action = "Edit" });

            routes.MapRoute(
            name: "DefaultLocalized",
            url: "{lang}/{controller}/{action}/{id}",
            defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional, },
            constraints: new { lang = @"fr|en" }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index",id = UrlParameter.Optional, lang = "en" }
            );    
            
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
