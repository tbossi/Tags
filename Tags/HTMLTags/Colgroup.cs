using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Colgroup : Tag, SupportSpanAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        
        public Colgroup() : base("colgroup") { }
    }
}