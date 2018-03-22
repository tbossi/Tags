using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Sup : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Sup() : base("sup") { }
    }
}