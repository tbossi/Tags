using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Object : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Object() : base("object") { }
    }
}