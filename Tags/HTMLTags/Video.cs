using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Video : Tag, SupportAutoplayAttribute, SupportControlsAttribute,
        SupportHeightAttribute, SupportLoopAttribute, SupportMutedAttribute,
        SupportPreloadAttribute, SupportSrcAttribute, SupportWidthAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Video() : base("video") { }

        public virtual void AddPoster(string url)
        {
            AddAttribute("poster", url);
        }
    }
}