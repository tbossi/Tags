using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Button : Tag, SupportAutofocusAttribute, SupportDisabledAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Button() : base("button") { }
    }
}