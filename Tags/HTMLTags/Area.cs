using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Area : Tag, SupportAltAttribute, SupportTargetAttribute,
        SupportDownloadAttribute, SupportMediaQueryAttribute, SupportRelAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        public Area() : base("area") { }

        public virtual void AddCoords(string coords)
        {
            AddAttribute("coords", coords);
        }

        public virtual void AddHref(string href)
        {
            AddAttribute("href", href);
        }

        public virtual void AddShape(Shape shape)
        {
            AddAttribute("shape", shape.LiteralValue());
        }
    }
}