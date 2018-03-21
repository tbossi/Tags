using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class H4 : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public H4() : base("h4") { }
    }
}