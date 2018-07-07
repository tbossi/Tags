using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Video : Tag, SupportAutoplayAttribute, SupportControlsAttribute,
        SupportHeightAttribute, SupportLoopAttribute, SupportMutedAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Video() : base("video") { }
    }
}