using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Body : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Body() : base("body") { }
    }
}