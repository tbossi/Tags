using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Form : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Form() : base("form") { }
    }
}