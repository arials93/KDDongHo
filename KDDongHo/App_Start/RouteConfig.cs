﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KDDongHo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "AdminDashBoard", action = "Index" }
            );

            routes.MapRoute(
                name: "Product",
                url: "{controller}/{action}",
                defaults: new { controller = "AdminDashBoard", action = "Product" }
            ); 
        }
    }
}
