using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class H1 : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public H1() : base("h1") { }
    }
}