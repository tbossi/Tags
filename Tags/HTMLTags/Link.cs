using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Link : Tag, SupportMediaQueryAttribute, SupportMIMETypeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        public Link(string href) : base("link")
        {
            AddAttribute("href", href);
        }

        public virtual void AddRel(LinkRel rel)
        {
            AddAttribute("rel", rel.LiteralValue());
        }

        public virtual void AddCrossorigin(Crossorigin crossorigin)
        {
            AddAttribute("crossorigin", crossorigin.LiteralValue());
        }
    }
}