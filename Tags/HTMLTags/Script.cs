using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public abstract class Script : Tag, SupportMIMETypeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Script() : base("script")
        {
        }
    }
}