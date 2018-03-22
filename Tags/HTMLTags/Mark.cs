using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Mark : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Mark() : base("mark") { }
    }
}