using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class H5 : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public H5() : base("h5") { }
    }
}