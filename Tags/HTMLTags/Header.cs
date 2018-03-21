using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Header : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Header() : base("header") { }
    }
}