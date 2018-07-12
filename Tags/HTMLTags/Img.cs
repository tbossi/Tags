using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Img : Tag, SupportHeightAttribute, SupportSrcsetAttribute,
        SupportUsemapAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Img(string src, string alt) : base("img")
        {
            TagBuilder.MergeAttribute("src", src);
            TagBuilder.MergeAttribute("alt", alt);
        }
    }
}