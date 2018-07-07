using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Output : Tag, SupportForAttribute, SupportFormAttribute,
        SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Output() : base("output") { }
    }
}