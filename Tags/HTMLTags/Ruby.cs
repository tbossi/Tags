using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Ruby : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Ruby() : base("ruby") { }
    }
}