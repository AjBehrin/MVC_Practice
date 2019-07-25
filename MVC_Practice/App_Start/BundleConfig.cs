using System.Web;
using System.Web.Optimization;

namespace MVC_Practice
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/JS/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/JS/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/JS/lib/jquery.dataTables.min.js",
                        "~/JS/lib/dataTables.bootstrap4.min.js",
                        "~/JS/lib/dataTables.colReorder.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/CSS/bootstrap.min.css",
                        //"~/CSS/bootstrap-grid.min.css", Not sure if needed
                        "~/CSS/jquery.dataTables.min.css",                     
                        //"~/CSS/jquery-ui.min.css",
                        //"~/CSS/jquery-ui.theme.min.css",
                        "~/CSS/dataTables.bootstrap4.min.css",
                        "~/CSS/colReorder.bootstrap4.min.css",
                        "~/CSS/site.css"));
        }
    }
}
