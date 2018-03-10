using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Aside : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Aside() : base("aside") { }
    }
}