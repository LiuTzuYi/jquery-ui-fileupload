using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace jquery_ui_fileupload
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Contnet/site.css", "~/Content/font-awesome.css"));
            bundles.Add(new StyleBundle("~/Content/fileupload").Include("~/Contnet/fileupload/jquery.fileupload.css","~/Content/fileupload/jquery.fileupload-ui.css"));

            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include("~/Scripts/modernizr-2.8.3.js"));
            bundles.Add(new ScriptBundle("~/Scripts").Include("~/Scripts/jquery-3.2.1.js", 
                                                             "~/Scripts/jquery.validate.js", 
                                                             "~/Scripts/jquery.validate.unobtrusive.js", 
                                                             "~/Scripts/jquery-ui-1.12.1.js"));
            


            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/bootstrap.js","~/Scripts/respond.js"));


            // 載入的順序有差
            bundles.Add(new ScriptBundle("~/Scripts/fileupload").Include("~/Scripts/fileupload/jquery.ui.widget.js",
                                                                         "~/Scripts/fileupload/tmpl.js",
                                                                         "~/Scripts/fileupload/load-image.all.min.js",
                                                                         "~/Scripts/fileupload/canvas-to-blob.js",
                                                                         "~/Scripts/fileupload/blueimp-gallery.js",
                                                                         "~/Scripts/fileupload/jquery.blueimp-gallery.js",
                                                                         "~/Scripts/fileupload/jquery.iframe-transport.js",
                                                                         "~/Scripts/fileupload/jquery.fileupload.js",
                                                                         "~/Scripts/fileupload/jquery.fileupload-ui.js",
                                                                         
                                                                         "~/Scripts/fileupload/jquery.fileupload-process.js",
                                                                         "~/Scripts/fileupload/jquery.fileupload-image.js",
                                                                         "~/Scripts/fileupload/jquery.fileupload-audio.js",
                                                                         "~/Scripts/fileupload/jquery.fileupload-video.js",
                                                                         "~/Scripts/fileupload/jquery.fileupload-validate.js",
                                                                         "~/Scripts/fileupload/jqupload.main.js"));


            //bundles.Add(new StyleBundle("~/Content/jqupload-styles").Include(
            //    "~/node_modules/blueimp-gallery/css/blueimp-gallery.css",

            //    "~/node_modules/blueimp-file-upload/css/jquery.fileupload.css",
            //    "~/node_modules/blueimp-file-upload/css/jquery.fileupload-ui.css"

            //    ));

            //bundles.Add(new ScriptBundle("~/bundles/jqupload").Include(
            //    "~/node_modules/blueimp-file-upload/js/vendor/jquery.ui.widget.js",

            //    "~/node_modules/blueimp-tmpl/js/tmpl.js",
            //    "~/node_modules/blueimp-load-image/js/load-image.all.min.js",
            //    "~/node_modules/blueimp-canvas-to-blob/js/canvas-to-blob.js",
            //    "~/node_modules/blueimp-gallery/js/blueimp-gallery.js",
            //    "~/node_modules/blueimp-gallery/js/jquery.blueimp-gallery.js",

            //    "~/node_modules/blueimp-file-upload/js/jquery.iframe-transport.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload-process.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload-image.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload-audio.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload-video.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload-validate.js",
            //    "~/node_modules/blueimp-file-upload/js/jquery.fileupload-ui.js",
            //    "~/Scripts/jqupload.main.js"
            //    ));
        }
    }
}