using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Li : Tag, SupportNumberValueAttribute
    {
        private int? _value;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (_value.HasValue) { tag.MergeAttribute("value", _value.Value.ToString()); }

                return tag;
            }
        }

        public Li() : base("li") { }

        public void AddValue(int value)
        {
            _value = value;
        }
    }
}