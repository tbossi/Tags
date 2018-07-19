using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Param : Tag, SupportNameAttribute, SupportStringValueAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Param() : base("param") { }
    }
}