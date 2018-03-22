using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Tr : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Tr() : base("tr") { }
    }
}