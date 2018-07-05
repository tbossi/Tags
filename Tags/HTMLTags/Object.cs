using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Object : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Object() : base("object") { }

        public void AddData(string data)
        {
            TagBuilder.MergeAttribute("data", data);
        }
    }
}