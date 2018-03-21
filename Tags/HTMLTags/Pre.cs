using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Pre : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Pre() : base("pre") { }
    }
}