using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Style : Tag, SupportMediaQueryAttribute, SupportMIMETypeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Style() : base("style") { }
    }
}