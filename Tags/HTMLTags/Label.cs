using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Label : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Label() : base("label") { }
    }
}