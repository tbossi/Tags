using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Abbr : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Abbr() : base("abbr") { }
    }
}