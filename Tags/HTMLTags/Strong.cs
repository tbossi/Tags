using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Strong : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Strong() : base("strong") { }
    }
}