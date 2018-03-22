using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Datalist : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Datalist() : base("datalist") { }
    }
}