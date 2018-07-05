using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Area : Tag, SupportAltAttribute, SupportTargetAttribute, SupportDownloadAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Area() : base("area") { }

        public virtual void AddCoords(string coords)
        {
            TagBuilder.MergeAttribute("coords", coords);
        }
    }
}