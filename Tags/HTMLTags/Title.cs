using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Title : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Title() : base("title") { }
    }
}