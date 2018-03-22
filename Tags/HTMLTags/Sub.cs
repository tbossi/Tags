using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Sub : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Sub() : base("sub") { }
    }
}