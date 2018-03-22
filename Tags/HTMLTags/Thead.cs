using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Thead : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Thead() : base("thead") { }
    }
}