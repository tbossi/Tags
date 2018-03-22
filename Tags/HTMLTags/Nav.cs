using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Nav : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Nav() : base("nav") { }
    }
}