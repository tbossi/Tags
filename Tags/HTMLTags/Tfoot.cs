using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Tfoot : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Tfoot() : base("tfoot") { }
    }
}