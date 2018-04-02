using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Map : Tag, SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Map() : base("map") { }
    }
}