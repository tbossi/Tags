using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class H2 : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public H2() : base("h2") { }
    }
}