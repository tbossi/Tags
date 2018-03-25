using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Colgroup : Tag, SupportSpanAttribute
    {
        private int? _span;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (_span.HasValue) { tag.MergeAttribute("span", _span.Value.ToString()); }

                return tag;
            }
        }
        
        public Colgroup() : base("colgroup") { }

        public void AddSpan(int span)
        {
            _span = span;
        }
    }
}