using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Button : Tag, SupportAutofocusAttribute, SupportDisabledAttribute,
        SupportFormAttribute, SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Button() : base("button") { }
    }
}