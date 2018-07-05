using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Style : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Style() : base("style") { }
    }
}