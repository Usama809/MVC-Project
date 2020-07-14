using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_Custom_HTML_Helper
{
    public static class CustomeHelper
    {
        public static IHtmlString image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt= '{1}'></img>", src, alt));
        }
        public static IHtmlString img(this HtmlHelper helper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt= '{1}'></img>", src, alt));
        }
        public static IHtmlString imgTag(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src",src);
            tag.Attributes.Add("alt", alt);

            return new MvcHtmlString(tag.ToString());
        }
    }
}