using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Dl : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Dl() : base("dl") { }
    }
}