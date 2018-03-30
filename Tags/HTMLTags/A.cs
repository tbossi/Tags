using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class A : Tag, SupportRelAttribute, SupportTargetAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public A(string href) : base("a")
        {
            if (!string.IsNullOrEmpty(href)) { TagBuilder.MergeAttribute("href", href); }
        }

        public virtual void AddDownload(string newFileName)
        {
            TagBuilder.MergeAttribute("download", newFileName);
        }
    }
}