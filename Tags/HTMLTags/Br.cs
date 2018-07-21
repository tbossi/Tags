using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Br : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;
        public Br() : base("br") { }
    }
}