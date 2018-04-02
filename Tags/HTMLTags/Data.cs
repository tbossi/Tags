using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Data : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Data(string value) : base("data")
        {
            TagBuilder.MergeAttribute("value", value);
        }
    }
}