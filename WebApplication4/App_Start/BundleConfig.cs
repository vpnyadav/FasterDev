using System.Web;
using System.Web.Optimization;

namespace WebApplication4
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
          "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                       "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/bundles/DataTablecss").Include("~/Content/DataTables/media/css/jquery.dataTables.min.css",
                "~/Content/DataTables/media/css/dataTables.bootstrap.min.css",
                "~/Content/DataTables/extensions/Buttons/css/buttons.bootstrap.min.css",
                "~/Content/DataTables/extensions/FixedHeader/css/fixedHeader.bootstrap.min.css",
                "~/Content/DataTables/extensions/Responsive/css/responsive.bootstrap.min.css",
                "~/Content/DataTables/extensions/Scroller/css/scroller.bootstrap.min.css",
                "~/Content/jquery.pnotify.css"

                ));

            bundles.Add(new ScriptBundle("~/bundles/DataTablescript").Include("~/Scripts/DataTables/media/js/jquery.dataTables.min.js",
                "~/Scripts/DataTables/media/js/dataTables.bootstrap.min.js",
                "~/Scripts/DataTables/extensions/Buttons/js/dataTables.buttons.min.js",
                "~/Scripts/DataTables/extensions/Buttons/js/buttons.bootstrap.min.js",
                "~/Scripts/DataTables/extensions/Buttons/js/buttons.flash.min.js",
                "~/Scripts/DataTables/extensions/Buttons/js/buttons.html5.min.js",
                "~/Scripts/DataTables/extensions/Buttons/js/buttons.print.min.js",
                "~/Scripts/DataTables/extensions/FixedHeader/js/dataTables.fixedHeader.min.js",
                "~/Scripts/DataTables/extensions/KeyTable/js/dataTables.keyTable.js",
                "~/Scripts/DataTables/extensions/Responsive/js/dataTables.responsive.js",
                "~/Scripts/DataTables/extensions/Responsive/js/responsive.bootstrap.min.js",
                "~/Scripts/DataTables/extensions/Scroller/js/dataTables.scroller.min.js",


                "~/Scripts/jquery.pnotify.js"


                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
