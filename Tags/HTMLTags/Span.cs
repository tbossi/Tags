using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Span : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Span() : base("span") { }
    }
}