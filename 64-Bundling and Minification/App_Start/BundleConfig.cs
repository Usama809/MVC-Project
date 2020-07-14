using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace _64_Bundling_and_Minification
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
                          //Include
            //var bundle = new ScriptBundle("~/bundles/js");

            //bundle.Include("~/Content/JS/JavaScript1.js",
            //    "~/Content/JS/JavaScript2.js",
            //    "~/Content/JS/JavaScript3.js",
            //    "~/Content/JS/JavaScript4.js",
            //    "~/Content/JS/JavaScript5.js");

            //bundles.Add(bundle);

            //include Directory

            bundles.Add(new ScriptBundle("~/bundles/js").IncludeDirectory("~/Content/JS" ,"*.js"));


            //Include CSS
            bundles.Add(new StyleBundle("~/bundle/css")Include("~/Content/Styles/StyleSheet1.css", "~/Content/Styles/StyleSheet2.css"));
            BundleTable.EnableOptimizations = true;




        }
    }
}