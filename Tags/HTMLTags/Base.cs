using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Base : Tag
    {
        private readonly string _href;
        private Target? _target;

        public override TagRenderMode TagRenderMode => TagRenderMode.SelfClosing;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (!string.IsNullOrEmpty(_href)) { tag.MergeAttribute("href", _href); }
                if (_target.HasValue) { tag.MergeAttribute("target", _target.Value.LiteralValue()); }

                return tag;
            }
        }

        public Base(string href, Target? target = null) : base("base")
        {
            _href = href;
            _target = target;
        }

        public Base(Target target) : base("base")
        {
            _target = target;
        }
    }
}