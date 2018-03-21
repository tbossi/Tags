using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Hr : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Hr() : base("hr") { }
    }
}