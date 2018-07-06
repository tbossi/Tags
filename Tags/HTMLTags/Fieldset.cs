using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Fieldset : Tag, SupportDisabledAttribute, SupportFormAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Fieldset() : base("fieldset") { }
    }
}