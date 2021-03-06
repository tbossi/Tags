using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Source : Tag, SupportMediaQueryAttribute, SupportMIMETypeAttribute,
        SupportSrcAttribute, SupportSrcsetAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;
        public Source() : base("source") { }
    }
}