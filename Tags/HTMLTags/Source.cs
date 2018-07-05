using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Source : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Source() : base("source") { }
    }
}