using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Optgroup : Tag, SupportDisabledAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Optgroup() : base("optgroup") { }
    }
}