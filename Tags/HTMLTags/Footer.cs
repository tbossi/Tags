using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Footer : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Footer() : base("footer") { }
    }
}