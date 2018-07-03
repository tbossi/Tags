using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Meter : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Meter() : base("meter") { }
    }
}