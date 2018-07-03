using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Audio : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Audio() : base("audio") { }
    }
}