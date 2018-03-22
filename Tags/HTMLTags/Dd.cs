using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Dd : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Dd() : base("dd") { }
    }
}