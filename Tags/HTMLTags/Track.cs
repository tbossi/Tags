using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Track : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Track() : base("track") { }
    }
}