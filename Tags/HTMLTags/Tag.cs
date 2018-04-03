using System.Collections.Generic;
using System.Web.Mvc;
using System.Text;
using System;

namespace Tags.HTMLTags
{
    public interface ITag : InnerHtml
    {
        TagBuilder TagBuilder { get; }
        TagRenderMode TagRenderMode { get; }
    }

    public abstract class Tag : ITag
    {
        private readonly List<InnerHtml> _content;

        public TagBuilder TagBuilder { get; }
        public abstract TagRenderMode TagRenderMode { get; }

        public Tag(string name)
        {
            TagBuilder = new TagBuilder(name);
            _content = new List<InnerHtml>();
        }

        public void AddInnerHtml(params InnerHtml[] html)
        {
            _content.AddRange(html);
        }

        public sealed override string ToString()
        {
            if (_content.Count > 0)
            {
                var tagContent = new StringBuilder();
                foreach (var item in _content)
                {
                    tagContent.Append(item.ToString());
                }

                TagBuilder.InnerHtml = tagContent.ToString();
            }

            return TagBuilder.ToString(TagRenderMode);
        }
    }
}