using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Rt : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Rt() : base("rt") { }
    }
}