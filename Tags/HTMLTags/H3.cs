using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class H3 : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public H3() : base("h3") { }
    }
}