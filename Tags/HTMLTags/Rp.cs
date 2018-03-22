using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Rp : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Rp() : base("rp") { }
    }
}