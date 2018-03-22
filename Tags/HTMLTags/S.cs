using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class S : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public S() : base("s") { }
    }
}