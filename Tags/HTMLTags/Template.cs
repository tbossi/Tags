using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Template : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Template() : base("template") { }
    }
}