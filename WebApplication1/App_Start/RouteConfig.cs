using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Custom Route : search
            routes.MapRoute(
                "ArticleByReleaseDate",
                "Article/released/{year}/{month}",
                new {controller="Article", action="ByReleaseDate"});
            //Custom Route : search by characters

            routes.MapRoute(
                "ArticleByReleaseDateChar",
                "Article/release/{year}/{month}",
                new { controller = "Article", action = "ByReleaseDatechar" },
                new { year=@"\d{4}", month=@"\d{2}"});

            //Custom Route : Intervalle entre deux dates Attribute Routing

            routes.MapRoute(
               "ArticleByReleasePeriodDate",
               "Article/release/{year}/{month}",
               new { controller = "Article", action = "ByReleaseDatePeriod" },
               new { year = @"2017|2018", month = @"\d{2}" });



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
