using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Bdo : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Bdo(Dir dir) : base("bdo")
        {
            TagBuilder.MergeAttribute("dir", dir.LiteralValue());
        }
    }
}