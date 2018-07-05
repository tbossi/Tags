using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Textarea : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Textarea() : base("textarea") { }
    }
}