using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Img : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Img() : base("img") { }
    }
}