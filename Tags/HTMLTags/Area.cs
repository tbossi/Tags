using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Area : Tag, SupportAltAttribute, SupportTargetAttribute,
        SupportDownloadAttribute, SupportMediaQueryAttribute, SupportRelAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Area() : base("area") { }

        public virtual void AddCoords(string coords)
        {
            TagBuilder.MergeAttribute("coords", coords);
        }

        public virtual void AddHref(string href)
        {
            TagBuilder.MergeAttribute("href", href);
        }

        public virtual void AddShape(Shape shape)
        {
            TagBuilder.MergeAttribute("shape", shape.LiteralValue());
        }
    }
}