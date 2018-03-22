using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Legend : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Legend() : base("legend") { }
    }
}