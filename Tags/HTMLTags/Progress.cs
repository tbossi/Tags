using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Progress : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Progress() : base("progress") { }
    }
}