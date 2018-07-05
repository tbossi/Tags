using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Select : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Select() : base("select") { }
    }
}