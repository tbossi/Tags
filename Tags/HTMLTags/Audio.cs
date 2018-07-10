using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Audio : Tag, SupportAutoplayAttribute, SupportControlsAttribute,
        SupportLoopAttribute, SupportMutedAttribute, SupportPreloadAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Audio() : base("audio") { }
    }
}