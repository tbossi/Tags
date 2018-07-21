using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Object : Tag, SupportFormAttribute, SupportHeightAttribute,
        SupportNameAttribute, SupportMIMETypeAttribute, SupportUsemapAttribute,
        SupportWidthAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Object() : base("object") { }

        public void AddData(string data)
        {
            AddAttribute("data", data);
        }
    }
}