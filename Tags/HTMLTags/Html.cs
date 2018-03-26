using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Html : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Html() : base("html") { }
    }
}