using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Output : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Output() : base("output") { }
    }
}