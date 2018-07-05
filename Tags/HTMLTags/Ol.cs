using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Ol : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Ol() : base("ol") { }
    }
}