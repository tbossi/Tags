using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Picture : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Picture() : base("picture") { }
    }
}