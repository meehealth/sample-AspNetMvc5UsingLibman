using System.Web;
using System.Web.Optimization;

namespace AspNetMvc5UsingLibman
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/wwwroot/lib/jquery/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/wwwroot/lib/jquery-validate/jquery.validate.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryvalunobtrusive").Include(
                        "~/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/wwwroot/lib/modernizr/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/wwwroot/lib/bootstrap/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/wwwroot/js/site.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/wwwroot/lib/bootstrap/css/bootstrap.css",
                      "~/wwwroot/css/site.css"));
        }
    }
}
