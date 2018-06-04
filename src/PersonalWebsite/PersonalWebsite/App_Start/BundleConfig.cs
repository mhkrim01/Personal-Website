using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace PersonalWebsite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            BundleTable.EnableOptimizations = true;
            BundleTable.Bundles.UseCdn = true;
#endif

            bundles.Add(new StyleBundle("~/Content/css", "https://stackpath.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.min.css"));

            //bundles.Add(new StyleBundle("~/bundles/css", "https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/particles.css")
                .Include("~/Content/styles.css")
                .Include("~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/common-js", "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.0.0.js")
                .Include("~/Scripts/jquery-3.0.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/particles", "https://cdn.jsdelivr.net/npm/particles.js@2.0.0/particles.min.js")
                .Include("~/Scripts/particles.js"));

            bundles.Add(new ScriptBundle("~/bundles/app-js")
                .Include("~/Scripts/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/google-analytics")
                .Include("~/Scripts/google-analytics.js"));

        }
    }
}