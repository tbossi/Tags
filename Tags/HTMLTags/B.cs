using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class B : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public B() : base("b") { }
    }
}