using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Progress : Tag, SupportNumberValueAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Progress() : base("progress") { }
    }
}