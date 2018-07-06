using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Img : Tag, SupportAltAttribute, SupportHeightAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Img() : base("img") { }
    }
}