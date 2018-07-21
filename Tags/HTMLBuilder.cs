using System;
using System.Collections.Generic;
using System.Text;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;

namespace Tags
{
    public abstract class HTMLBuilder
    {
        public static HTMLBuilder<Tag, HTMLBuilder> Tag => new HTMLBuilder<Tag, HTMLBuilder>(null, null);

        private List<Tag> _storedTags;

        public HTMLBuilder()
        {
            _storedTags = new List<Tag>();
        }

        protected void StoreTag(Tag tag)
        {
            _storedTags.Add(tag);
        }

        public override sealed string ToString()
        {
            var sb = new StringBuilder();
            _storedTags.ForEach(t => { sb = t.Render(sb); });
            return sb.ToString();
        }
    }

    public class HTMLBuilder<CurrentTagType, ParentBuilderType> : HTMLBuilder
        where CurrentTagType : Tag
        where ParentBuilderType : HTMLBuilder
    {
        private readonly ParentBuilderType _parentTag;
        public CurrentTagType CurrentTag { get; }

        internal HTMLBuilder(CurrentTagType currentTag, ParentBuilderType parentTag) : base()
        {
            CurrentTag = currentTag;
            _parentTag = parentTag;
        }

        public virtual HTMLBuilder<T, HTMLBuilder<CurrentTagType, ParentBuilderType>> StoreTag<T>(T tag) where T : Tag
        {
            base.StoreTag(tag);
            if (_parentTag != null) { CurrentTag.AddInnerHtml(tag); }
            return new HTMLBuilder<T, HTMLBuilder<CurrentTagType, ParentBuilderType>>(tag, this);
        }

        public virtual ParentBuilderType End()
        {
            if (_parentTag == null) { throw new NullReferenceException(); }
            return _parentTag;
        }

        public virtual HTMLBuilder<Tag, HTMLBuilder> EndAll()
        {
            // hack to avoid generic types checking
            dynamic x = _parentTag;
            while (x != null) { x = x.End(); }
            return x;
        }

        public virtual HTMLBuilder<CurrentTagType, ParentBuilderType> InnerHTML(params Tag[] innerHtml)
        {
            CurrentTag.AddInnerHtml(innerHtml);
            return this;
        }

        public virtual HTMLBuilder<CurrentTagType, ParentBuilderType> InnerText(string text)
        {
            CurrentTag.AddInnerHtml(new Text(text));
            return this;
        }

        public virtual HTMLBuilder<CurrentTagType, ParentBuilderType> Class(params string[] classes)
        {
            CurrentTag.AddClasses(classes);
            return this;
        }

        public virtual HTMLBuilder<CurrentTagType, ParentBuilderType> Id(string id)
        {
            CurrentTag.AddId(id);
            return this;
        }

        public virtual HTMLBuilder<CurrentTagType, ParentBuilderType> Data(string key, string value)
        {
            CurrentTag.AddData(key, value);
            return this;
        }

        public virtual HTMLBuilder<CurrentTagType, ParentBuilderType> Title(string title)
        {
            CurrentTag.AddTitle(title);
            return this;
        }
    }
}