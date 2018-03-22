using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Em : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Em() : base("em") { }
    }
}