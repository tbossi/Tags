using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class A : Tag, SupportRelAttribute, SupportTargetAttribute, SupportDownloadAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public A(string href) : base("a")
        {
            if (!string.IsNullOrEmpty(href)) { TagBuilder.MergeAttribute("href", href); }
        }        
    }
}