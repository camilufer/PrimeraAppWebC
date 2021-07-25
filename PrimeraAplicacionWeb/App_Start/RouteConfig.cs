using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PrimeraAplicacionWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cliente",
                url: "cliente/{rut}",
                defaults: new 
                {
                    controller = "Cliente",
                    action = "Buscar", 
                    rut = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Persona",
                url: "{controller}/{action}/{rut}",
                defaults: new
                {
                    controller = "Persona",
                    action = "Listado",
                    rut = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{nombre}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional,
                    nombre = UrlParameter.Optional
                }
            );
        }
    }
}
