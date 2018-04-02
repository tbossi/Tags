using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Td : Tag, SupportColspanAttribute, SupportRowspanAttribute, SupportHeadersAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Td() : base("td") { }
    }
}