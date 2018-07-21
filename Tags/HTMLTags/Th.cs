using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Th : Tag, SupportColspanAttribute, SupportRowspanAttribute, SupportHeadersAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Th() : base("th") { }

        public virtual void AddScope(Scope scope)
        {
            AddAttribute("scope", scope.LiteralValue());
        }
    }
}