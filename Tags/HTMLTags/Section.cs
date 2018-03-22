using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Section : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Section() : base("section") { }
    }
}