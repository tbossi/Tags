using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Col : Tag, SupportSpanAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        
        public Col() : base("col") { }
    }
}