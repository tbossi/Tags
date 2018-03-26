using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Embed : Tag, SupportHeightAttribute, SupportWidthAttribute, SupportMIMETypeAttribute
    {
        private int? _height;
        private int? _width;
        private string _src;
        private string _type;

        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                tag.MergeAttribute("src", _src);
                if (_height.HasValue) { tag.MergeAttribute("height", _height.Value.ToString()); }
                if (_width.HasValue) { tag.MergeAttribute("width", _width.Value.ToString()); }
                if (!string.IsNullOrEmpty(_type)) { tag.MergeAttribute("type", _type); }

                return tag;
            }
        }

        public Embed(string src) : base("embed")
        {
            _src = src;
        }

        public void AddHeight(int height)
        {
            _height = height;
        }

        public void AddWidth(int width)
        {
            _width = width;
        }

        public void AddType(string type)
        {
            _type = type;
        }
    }
}