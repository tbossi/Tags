using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Input : Tag, SupportAltAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Input() : base("input") { }

        public void AddAccept(string fileType)
        {
            TagBuilder.MergeAttribute("accept", fileType);
        }
    }
}