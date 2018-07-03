using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Button : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Button() : base("button") { }
    }
}