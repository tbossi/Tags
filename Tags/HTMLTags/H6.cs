using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class H6 : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public H6() : base("h6") { }
    }
}