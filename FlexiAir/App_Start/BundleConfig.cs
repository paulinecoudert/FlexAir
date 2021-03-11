using System.Web;
using System.Web.Optimization;

namespace FlexiAir
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/css/fontawesome-all.min.css",
                    "~/Content/bootstrap.css",
                    "~/css/magnific-popup.css",
                    "~/slick/slick.css",
                    "~/slick/slick-theme.css",
                    "~/css/tooplate-style.css"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/magnificpopup").Include
                (
                 "~/js/jquery.magnific-popup.min.js"
                ));
            bundles.Add(new ScriptBundle("~/js/backstretch").Include
                (
                 "~/js/jquery.backstretch.min.js"
                ));
            bundles.Add(new ScriptBundle("~/slick/slick").Include
                (
                 "~/slick/slick.min.js"
                ));
            

        }
    }
}
