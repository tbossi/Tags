using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Wbr : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;
        public Wbr() : base("wbr") { }
    }
}