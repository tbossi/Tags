using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Bdo : Tag
    {
        private readonly Dir _dir;
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tagToBuild = base.GeneratedTag;
                tagToBuild.MergeAttribute("dir", _dir.LiteralValue());
                return tagToBuild;
            }
        } 

        public Bdo(Dir dir) : base("bdo")
        {
            _dir = dir;
        }
    }
}