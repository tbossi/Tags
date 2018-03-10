using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class P : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public P() : base("p") { }
    }
}