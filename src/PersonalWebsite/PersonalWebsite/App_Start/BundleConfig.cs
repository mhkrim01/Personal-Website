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

            bundles.Add(new StyleBundle("~/Content/css", "https://ajax.aspnetcdn.com/ajax/bootstrap/3.0.0/css/bootstrap.css")
                .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/particles.css")
                .Include("~/Content/Site.css")
                .Include("~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/common-js", "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.0.0.js")
                .Include("~/Scripts/jquery-3.0.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://ajax.aspnetcdn.com/ajax/bootstrap/3.0.0/bootstrap.js")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/particles")
                .Include("~/Scripts/particles.js"));

        }
    }
}