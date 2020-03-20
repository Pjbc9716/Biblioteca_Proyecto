using System.Web;
using System.Web.Optimization;

namespace Intento1
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/sweet-alert.min.js",
                      "~/Scripts/js/jquery-1.11.2.min.js",
                      "~/Scripts/js/modernizr.js",
                      "~/Scripts/js/bootstrap.min.js", 
                      "~/Scripts/js/jquery.mCustomScrollbar.concat.min.js",
                      "~/Scripts/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/sweet-alert.css",
                      "~/Content/css/material-design-iconic-font.min.css",
                      "~/Content/css/normalize.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/jquery.mCustomScrollbar.css",
                      "~/Content/css/style.css",
                      "~/Content/css/login.css",
                      "~/Content/css/timeline.css"));
        }
    }
}