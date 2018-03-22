using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Dfn : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Dfn() : base("dfn") { }
    }
}