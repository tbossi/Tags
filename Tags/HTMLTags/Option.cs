using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Option : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Option() : base("option") { }
    }
}