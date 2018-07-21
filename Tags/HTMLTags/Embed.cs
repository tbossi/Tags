using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Embed : Tag, SupportHeightAttribute, SupportWidthAttribute, SupportMIMETypeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        public Embed(string src) : base("embed")
        {
            AddAttribute("src", src);
        }
    }
}