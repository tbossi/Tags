using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Figure : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Figure() : base("figure") { }
    }
}