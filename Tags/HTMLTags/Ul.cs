using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Ul : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Ul() : base("ul") { }
    }
}