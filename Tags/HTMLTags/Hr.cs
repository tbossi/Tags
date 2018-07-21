using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Hr : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;
        public Hr() : base("hr") { }
    }
}