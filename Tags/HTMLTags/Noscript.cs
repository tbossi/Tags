using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Noscript : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Noscript() : base("noscript") { }
    }
}