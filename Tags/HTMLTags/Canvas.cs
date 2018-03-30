using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Canvas : Tag, SupportHeightAttribute, SupportWidthAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Canvas() : base("canvas") { }
    }
}