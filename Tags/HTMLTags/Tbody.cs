using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Tbody : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Tbody() : base("tbody") { }
    }
}