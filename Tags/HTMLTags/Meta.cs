using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Meta : Tag, SupportCharsetAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Meta() : base("meta") { }

        public virtual void AddName(Name name, string content)
        {
            if (string.IsNullOrWhiteSpace(content)) { throw new ArgumentException(); }
            TagBuilder.MergeAttribute("content", content);
            TagBuilder.MergeAttribute("name", name.LiteralValue());
        }

        public virtual void AddHttpEquiv(HttpEquiv httpEquiv, string content)
        {
            if (string.IsNullOrWhiteSpace(content)) { throw new ArgumentException(); }
            TagBuilder.MergeAttribute("content", content);
            TagBuilder.MergeAttribute("http-equiv", httpEquiv.LiteralValue());
        }
    }
}