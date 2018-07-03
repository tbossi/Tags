using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Input : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Input() : base("input") { }
    }
}