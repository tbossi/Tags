using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Head : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Head() : base("head") { }
    }
}