using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BinbinBundleConfig
{
    public static class BundleHelper
    {
        public static void AddScriptBundleAngular(this BundleCollection bundles, List<string> bowerPlugins = null)
        {
            Bundle bundle = new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular.js", "~/Scripts/angular-animate.js", "~/Scripts/angular-cookies.js", "~/Scripts/angular-loader.js", "~/Scripts/angular-mocks.js", "~/Scripts/angular-resource.js", "~/Scripts/angular-route.js", "~/Scripts/angular-scenario.js", "~/Scripts/angular-touch.js");
            if (null != bowerPlugins && bowerPlugins.Count > 0)
            {
                if (bowerPlugins.Contains("angular-loading-bar"))
                {
                    bundle.Include("~/bower_components/angular-loading-bar/build/loading-bar.js");
                }
            }
            bundles.Add(bundle);
        }

        public static void AddStyleBundleAngular(this BundleCollection bundles, List<string> bowerPlugins = null)
        {
            Bundle bundle = new StyleBundle("~/Content/angular");
            if (null != bowerPlugins && bowerPlugins.Count > 0)
            {
                if (bowerPlugins.Contains("angular-loading-bar"))
                {
                    bundle.Include("~/bower_components/angular-loading-bar/build/loading-bar.css");
                }
            }
            bundles.Add(bundle);
        }

        public static void AddStyleBundleBootstrap(this BundleCollection bundles, List<string> bowerPlugins = null)
        {
            Bundle bundle = new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css")
                                                                  .Include("~/Content/bootstrap-theme.css");
            if (null != bowerPlugins && bowerPlugins.Count > 0)
            {
                if (bowerPlugins.Contains("angular-loading-bar"))
                {
                    bundle.Include("~/bower_components/angular-loading-bar/build/loading-bar.css");
                }
            }
            bundles.Add(bundle);
        }
    }

    public static class RouteHelper
    {
        public static void AddRouteAngular(this RouteCollection routes)
        {
            routes.IgnoreRoute("fonts/{*pathInfo}");
        }
    }
}