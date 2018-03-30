using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Base : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        public Base(string href, Target? target = null) : base("base")
        {
            if (!string.IsNullOrEmpty(href)) { TagBuilder.MergeAttribute("href", href); }
            if (target.HasValue) { TagBuilder.MergeAttribute("target", target.Value.LiteralValue()); }
        }

        public Base(Target target) : base("base")
        {
            TagBuilder.MergeAttribute("target", target.LiteralValue());
        }
    }
}