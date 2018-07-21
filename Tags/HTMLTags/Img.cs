using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Img : Tag, SupportHeightAttribute, SupportSrcsetAttribute,
        SupportUsemapAttribute, SupportWidthAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        public Img(string src, string alt) : base("img")
        {
            AddAttribute("src", src);
            AddAttribute("alt", alt);
        }
    }
}