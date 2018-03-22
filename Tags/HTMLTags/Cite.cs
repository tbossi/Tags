using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Cite : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Cite() : base("cite") { }
    }
}