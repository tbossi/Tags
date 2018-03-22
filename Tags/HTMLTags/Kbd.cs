using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Kbd : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Kbd() : base("kbd") { }
    }
}