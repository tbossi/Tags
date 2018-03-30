using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Blockquote : Tag, SupportCiteAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Blockquote() : base("blockquote") { }
    }
}