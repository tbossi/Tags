using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Main : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Main() : base("main") { }
    }
}