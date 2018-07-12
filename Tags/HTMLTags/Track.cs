using System.Web.Mvc;
using Tags.Exception;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Track : Tag, SupportLabelAttribute, SupportSrcAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Track() : base("track") { }

        public virtual void AddDefault()
        {
            TagBuilder.MergeAttribute("default", "default");
        }

        public virtual void AddKind(Kind kind, string srclang = null)
        {
            if (!string.IsNullOrEmpty(srclang))
            {
                TagBuilder.MergeAttribute("srclang", srclang);
            }
            else if (kind == Kind.Subtitles)
            {
                throw new InvalidAttribute("kind", this);
            }
            TagBuilder.MergeAttribute("kind", kind.LiteralValue());
        }
    }
}