using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Param : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;
        public Param() : base("param") { }
    }
}