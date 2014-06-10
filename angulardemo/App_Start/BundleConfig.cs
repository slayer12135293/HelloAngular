using System.Web;
using System.Web.Optimization;

namespace angulardemo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
           

            var angularBundle = new ScriptBundle("~/angular");
            angularBundle.CdnPath = "//ajax.googleapis.com/ajax/libs/angularjs/1.2.10/angular.min.js";
            bundles.Add(angularBundle);

            var angularRouteBundle = new ScriptBundle("~/angularRoute");
            angularRouteBundle.CdnPath = "//ajax.googleapis.com/ajax/libs/angularjs/1.2.10/angular-route.min.js";
            bundles.Add(angularRouteBundle);


            var angularApp = new ScriptBundle("~/angularApp");
            angularApp.Include("~/Scripts/angular/*.js");
            bundles.Add(angularApp);

            bundles.UseCdn = true;



        }
    }
}