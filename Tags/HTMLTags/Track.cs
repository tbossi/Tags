using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Track : Tag, SupportLabelAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Track() : base("track") { }

        public virtual void AddDefault()
        {
            TagBuilder.MergeAttribute("default", "default");
        }

        public virtual void AddKind(Kind kind)
        {
            TagBuilder.MergeAttribute("kind", kind.LiteralValue());
        }
    }
}