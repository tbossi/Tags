using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Button : Tag, SupportAutofocusAttribute, SupportDisabledAttribute,
        SupportFormAttribute, SupportNameAttribute, SupportStringValueAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Button(ButtonType type) : base("button")
        {
            TagBuilder.MergeAttribute("type", type.LiteralValue());
        }
    }
}