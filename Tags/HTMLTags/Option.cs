using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Option : Tag, SupportDisabledAttribute, SupportLabelAttribute,
        SupportStringValueAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Option() : base("option") { }

        public virtual void AddSelected()
        {
            TagBuilder.MergeAttribute("selected", "selected");
        }
    }
}