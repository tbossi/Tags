using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Iframe : Tag, SupportHeightAttribute, SupportWidthAttribute, SupportNameAttribute
    {
        private int? _height;
        private int? _width;
        private string _src;
        private string _name;
        private string _srcdoc;
        private Sandbox[] _sandbox;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                tag.MergeAttribute("src", _src);
                if (_height.HasValue) { tag.MergeAttribute("height", _height.Value.ToString()); }
                if (_width.HasValue) { tag.MergeAttribute("width", _width.Value.ToString()); }
                if (!string.IsNullOrEmpty(_name)) { tag.MergeAttribute("name", _name); }
                if (!string.IsNullOrEmpty(_srcdoc)) { tag.MergeAttribute("srcdoc", _srcdoc); }

                foreach (var s in _sandbox)
                {
                    tag.MergeAttribute("sandbox", s.Value);
                }

                return tag;
            }
        }

        public Iframe(string src) : base("iframe")
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

        public void AddName(string name)
        {
            _name = name;
        }

        public void AddSrcdoc(string srcdoc)
        {
            _srcdoc = srcdoc;
        }

        public void AddSandbox(params Sandbox[] sandbox)
        {
            _sandbox = sandbox;
        }
    }
}