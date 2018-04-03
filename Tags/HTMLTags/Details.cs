using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Details : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Details() : base("details") { }

        public virtual void AddOpen()
        {
            TagBuilder.MergeAttribute("open", "open");
        }
    }
}