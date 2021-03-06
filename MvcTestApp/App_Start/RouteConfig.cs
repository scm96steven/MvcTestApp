﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcTestApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Subscriber Database",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Subscriber", action = "Show", id = UrlParameter.Optional}

                );

            routes.MapRoute(
          name: "City Database",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "City", action = "Show", id = UrlParameter.Optional }

          );



        }
    }
}