using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Select : Tag, SupportAutofocusAttribute, SupportDisabledAttribute, SupportFormAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Select() : base("select") { }
    }
}