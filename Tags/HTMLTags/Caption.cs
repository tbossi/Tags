using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Caption : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Caption() : base("caption") { }
    }
}