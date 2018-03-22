using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Summary : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Summary() : base("summary") { }
    }
}