using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Q : Tag, SupportCiteAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Q() : base("q") { }
    }
}