using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestCompany
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //you can create your own routes for each controller to produce different results. Use wisely! If you change the default routes be sure that the action you are linking to handles the request properly
            routes.MapRoute(
                "Employee",
                "Employee/{action}/{name}",
                new { controller = "Employee", action = "Url.Parameters.Optional", name = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            

            
        }
    }
}
