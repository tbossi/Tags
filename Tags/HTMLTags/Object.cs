using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Object : Tag, SupportFormAttribute, SupportHeightAttribute,
        SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Object() : base("object") { }

        public void AddData(string data)
        {
            TagBuilder.MergeAttribute("data", data);
        }
    }
}