using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace angulardemo.Infrastructure
{
    public static class CustomHelpers
    {
        public static int Sum(this HtmlHelper helper, int a, int b)
        {
            return a + b;
        }
        public static MvcHtmlString Image (this HtmlHelper helper, string src, string alt)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", src);
            builder.MergeAttribute("alt", alt);
            return MvcHtmlString.Create(builder.ToString());
        }
    }
}