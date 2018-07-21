using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Meta : Tag, SupportCharsetAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        public Meta() : base("meta") { }

        public virtual void AddName(Name name, string content)
        {
            if (string.IsNullOrWhiteSpace(content)) { throw new ArgumentException(); }
            AddAttribute("content", content);
            AddAttribute("name", name.LiteralValue());
        }

        public virtual void AddHttpEquiv(HttpEquiv httpEquiv, string content)
        {
            if (string.IsNullOrWhiteSpace(content)) { throw new ArgumentException(); }
            AddAttribute("content", content);
            AddAttribute("http-equiv", httpEquiv.LiteralValue());
        }
    }
}