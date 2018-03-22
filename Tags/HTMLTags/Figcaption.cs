using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Figcaption : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Figcaption() : base("figcaption") { }
    }
}