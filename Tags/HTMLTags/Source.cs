using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Source : Tag, SupportMediaQueryAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Source() : base("source") { }
    }
}