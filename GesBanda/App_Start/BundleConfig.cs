using System.Web;
using System.Web.Optimization;

namespace GesBanda
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/bower_components/bootstrap/dist/js/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/bower_components/bootstrap/dist/css/bootstrap.css",
                "~/bower_components/Ionicons/css/ionicons.min.css",
                "~/Content/site.css",
                "~/bower_components/admin-lte/dist/css/AdminLTE.css",
                "~/bower_components/admin-lte/dist/css/skins/skin-green.css"
            ));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                "~/bower_components/admin-lte/dist/js/adminlte.min.js",
                "~/bower_components/fastclick/lib/fastclick.js"
                ));


        }
    }
}
