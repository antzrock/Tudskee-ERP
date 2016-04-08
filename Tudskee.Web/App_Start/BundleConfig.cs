using System.Web;
using System.Web.Optimization;

namespace Tudskee.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/Vendors/angular.js",
                "~/Scripts/Vendors/angular-route.js",
                "~/Scripts/Vendors/angular-cookies.js",
                "~/Scripts/Vendors/angular-validator.js",
                "~/Scripts/Vendors/angular-base64.js",
                "~/Scripts/Vendors/angular-animate.js",
                "~/Scripts/Vendors/angular-sanitize.js",
                "~/Scripts/Vendors/angucomplete-alt.min.js",
                "~/Scripts/Vendors/ui-bootstrap-tpls-0.13.1.js",
                "~/Scripts/Vendors/toaster.js",
                "~/Scripts/Vendors/select.js",
                "~/Scripts/Vendors/ngletteravatar.js",
                "~/Scripts/Vendors/ng-flow-standalone.js",
                "~/Scripts/Vendors/smart-table.js",
                "~/Scripts/Vendors/xeditable.js",
                "~/Scripts/Vendors/checklist-model.js",
                "~/Scripts/Vendors/moment.js",
                "~/Scripts/Vendors/angular-bootstrap-checkbox.js",
                "~/Scripts/Vendors/angular-local-storage.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                "~/Scripts/spa/modules/common.core.js",
                "~/Scripts/spa/modules/common.ui.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/home/rootCtrl.js",
                "~/Scripts/spa/dashboard/dashboardCtrl.js",
                "~/Scripts/spa/layout/sideBar.directive.js",
                "~/Scripts/spa/layout/topBar.directive.js",
                "~/Scripts/spa/login/loginCtrl.js",
                "~/Scripts/spa/services/notificationService.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/content/fonts/font-awesome/css/font-awesome.min.css",
                "~/content/css/styles.css"
                ));

            BundleTable.EnableOptimizations = false;
        }
    }
}
