using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Option : Tag, SupportDisabledAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Option() : base("option") { }
    }
}