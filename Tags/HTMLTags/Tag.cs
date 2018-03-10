using System.Collections.Generic;
using System.Web.Mvc;
using System.Text;

namespace Tags.HTMLTags
{
    public abstract class Tag : InnerHtml
    {
        private readonly string _name;
        private string _id;
        private readonly HashSet<string> _classes;
        private readonly Dictionary<string, string> _datas;
        private string _title;
        private readonly List<InnerHtml> _content;

        public abstract TagRenderMode TagRenderMode { get; }

        protected virtual TagBuilder GeneratedTag
        {
            get
            {
                var tagToBuild = new TagBuilder(_name);
                if (!string.IsNullOrEmpty(_id)) { tagToBuild.GenerateId(_id); }
                foreach (var cl in _classes) { tagToBuild.AddCssClass(cl); }
                foreach (var dataAttribute in _datas)
                {
                    tagToBuild.MergeAttribute($"data-{dataAttribute.Key}", dataAttribute.Value);
                }
                if (!string.IsNullOrEmpty(_title)) { tagToBuild.MergeAttribute("title", _title); }

                var tagContent = new StringBuilder();
                foreach (var item in _content)
                {
                    tagContent.Append(item.ToString());
                }

                tagToBuild.InnerHtml = tagContent.ToString();

                return tagToBuild;
            }
        }

        public Tag(string name)
        {
            _name = name;
            _classes = new HashSet<string>();
            _datas = new Dictionary<string, string>();
            _content = new List<InnerHtml>();
        }

        public virtual void AddId(string id)
        {
            _id = id;
        }

        public virtual void AddClasses(params string[] classes)
        {
            foreach (var c in classes)
            {
                if (string.IsNullOrEmpty(c))
                    continue;

                _classes.Add(c);
            }
        }

        public virtual void AddData(string key, string value)
        {
            _datas[key] = value;
        }

        public virtual void AddTitle(string title)
        {
            _title = title;
        }

        public virtual void AddInnerHtml(params InnerHtml[] html)
        {
            _content.AddRange(html);
        }

        public sealed override string ToString()
        {
            return GeneratedTag.ToString(TagRenderMode);
        }
    }
}