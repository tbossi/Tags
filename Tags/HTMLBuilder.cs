using System.Collections.Generic;
using System.Text;
using Tags.HTMLTags;

namespace Tags
{
    public class HTMLBuilder
    {
        private Stack<Tag> _tagTree;
        private Tag _currentTag;
        private List<Tag> _topLevelTags;

        public static HTMLBuilder Tag => new HTMLBuilder();

        public virtual Tag CurrentOpenTag => _tagTree.Peek();

        private HTMLBuilder()
        {
            _tagTree = new Stack<Tag>();
            _currentTag = null;
            _topLevelTags = new List<Tag>();
        }

        internal virtual void StoreTag(Tag tag)
        {
            if (_tagTree.Count > 0) { CurrentOpenTag.AddInnerHtml(tag); }
            _tagTree.Push(tag);
        }

        public virtual HTMLBuilder End()
        {
            _currentTag = _tagTree.Pop();
            if (_tagTree.Count == 0)
            {
                _topLevelTags.Add(_currentTag);
            }
            return this;
        }

        public virtual HTMLBuilder EndAll()
        {
            while (_tagTree.Count > 0) { End(); }
            return this;
        }

        public virtual HTMLBuilder InnerHTML(params Tag[] innerHtml)
        {
            CurrentOpenTag.AddInnerHtml(innerHtml);
            return this;
        }

        public virtual HTMLBuilder InnerText(string text)
        {
            CurrentOpenTag.AddInnerHtml(new Text(text));
            return this;
        }

        public virtual HTMLBuilder Class(params string[] classes)
        {
            CurrentOpenTag.AddClasses(classes);
            return this;
        }

        public virtual HTMLBuilder Id(string id)
        {
            CurrentOpenTag.AddId(id);
            return this;
        }

        public virtual HTMLBuilder Data(string key, string value)
        {
            CurrentOpenTag.AddData(key, value);
            return this;
        }

        public virtual HTMLBuilder Title(string title)
        {
            CurrentOpenTag.AddTitle(title);
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            _topLevelTags.ForEach(t => sb.Append(t));
            return sb.ToString();
        }
    }
}