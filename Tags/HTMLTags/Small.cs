using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Small : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Small() : base("small") { }
    }
}