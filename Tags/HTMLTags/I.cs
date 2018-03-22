using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class I : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public I() : base("i") { }
    }
}