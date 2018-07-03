using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Area : Tag, SupportAltAttribute, SupportTargetAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Area() : base("area") { }
    }
}