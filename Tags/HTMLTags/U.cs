using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class U : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public U() : base("u") { }
    }
}