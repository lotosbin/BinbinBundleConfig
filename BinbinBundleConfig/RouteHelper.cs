using System.Web.Mvc;
using System.Web.Routing;

namespace BinbinBundleConfig
{
    public static class RouteHelper
    {
        public static void AddRouteAngular(this RouteCollection routes)
        {
            routes.IgnoreRoute("fonts/{*pathInfo}");
        }
    }
}