using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Optgroup : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Optgroup() : base("optgroup") { }
    }
}