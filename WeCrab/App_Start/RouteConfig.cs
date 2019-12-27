using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WeCrab
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //MAlO wydajne przez to ze zmieniajac nazwe kontrolera musimy pamietac o zmiane nazwy pola 'action = nowaNazwaKontrolera'
            // routes.MapRoute(
            //     "MovieByReleaseDate",
            //     "movies/released/{year}/{month}",
            //     new {controller = "Movies", action = "ByReleaseDate"},
            //     new{year = @"/d{4}", month = @"/d{2}"}); // ustawiam pewne stale ograniczenia dla rok(wymuszam 4 znaki) i miesiac (wymuszam 2 znaki)


            //W taki sposb lepiej robic sciezki
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
