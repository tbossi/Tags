using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Link : Tag, SupportMediaQueryAttribute, SupportMIMETypeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Link(string href) : base("link")
        {
            TagBuilder.MergeAttribute("href", href);
        }

        public virtual void AddRel(LinkRel rel)
        {
            TagBuilder.MergeAttribute("rel", rel.LiteralValue());
        }

        public virtual void AddCrossorigin(Crossorigin crossorigin)
        {
            TagBuilder.MergeAttribute("crossorigin", crossorigin.LiteralValue());
        }
    }
}