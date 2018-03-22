using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Code : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Code() : base("code") { }
    }
}