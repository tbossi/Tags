using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Bdi : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Bdi() : base("bdi") { }
    }
}