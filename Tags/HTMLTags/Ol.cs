using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Ol : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Ol() : base("ol") { }

        public virtual void AddReversed()
        {
            TagBuilder.MergeAttribute("reversed", "reversed");
        }

        public virtual void AddStart(int start)
        {
            TagBuilder.MergeAttribute("start", start.ToString());
        }
    }
}