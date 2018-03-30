using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Li : Tag, SupportNumberValueAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Li() : base("li") { }
    }
}