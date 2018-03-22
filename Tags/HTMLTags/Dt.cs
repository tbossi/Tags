using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Dt : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Dt() : base("dt") { }
    }
}