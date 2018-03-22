using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Samp : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Samp() : base("samp") { }
    }
}