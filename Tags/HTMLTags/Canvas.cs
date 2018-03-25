using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Canvas : Tag, SupportHeightAttribute, SupportWidthAttribute
    {
        private int? _height;
        private int? _width;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (_height.HasValue) { tag.MergeAttribute("height", _height.Value.ToString()); }
                if (_width.HasValue) { tag.MergeAttribute("width", _width.Value.ToString()); }

                return tag;
            }
        }
        
        public Canvas() : base("canvas") { }

        public void AddHeight(int height)
        {
            _height = height;
        }

        public void AddWidth(int width)
        {
            _width = width;
        }
    }
}