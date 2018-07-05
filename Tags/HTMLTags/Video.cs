using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Video : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Video() : base("video") { }
    }
}