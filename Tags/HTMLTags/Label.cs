using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Label : Tag, SupportForAttribute, SupportFormAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Label() : base("label") { }
    }
}