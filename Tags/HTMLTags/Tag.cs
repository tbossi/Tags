using System.Collections.Generic;
using System.Text;
using System;
using Tags.Encoders;
using Tags.Exception;

namespace Tags.HTMLTags
{
    public enum TagRenderMode
    {
        Normal, SelfClosing
    }

    public interface ITag : InnerHtml
    {
        string TagName { get; }
        List<InnerHtml> Content { get; }
        IDictionary<string, string> Attributes { get; }
        TagRenderMode TagRenderMode { get; }

        void AddAttribute(string key, string value = null, StringEncoder encoder = null);
    }

    public abstract class Tag : ITag
    {
        private static readonly StringEncoder DefaultAttributeEncoder = new AttributeEncoder();

        public string TagName { get; private set; }
        public List<InnerHtml> Content { get; private set; }
        public IDictionary<string, string> Attributes { get; private set; }
        public abstract TagRenderMode TagRenderMode { get; }

        public Tag(string tagName)
        {
            if (string.IsNullOrWhiteSpace(tagName))
            {
                throw new ArgumentException(ExceptionMessages.NotNullOrWhitespace("tagName"));
            }

            TagName = tagName;
            Content = new List<InnerHtml>();
            Attributes = new SortedDictionary<string, string>(StringComparer.Ordinal);
        }

        public virtual void AddInnerHtml(params InnerHtml[] html)
        {
            Content.AddRange(html);
        }

        public virtual void AddAttribute(string key, string value = null, StringEncoder encoder = null)
        {
            if (String.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException(ExceptionMessages.NotNullOrWhitespace("key"));
            }

            Attributes[key] = (encoder == null ? DefaultAttributeEncoder : encoder).Encode(value);
        }

        public StringBuilder Render(StringBuilder stringBuilder)
        {
            stringBuilder.Append('<').Append(TagName);

            foreach (var attribute in Attributes)
            {
                stringBuilder.Append(' ').Append(attribute.Key);

                if (attribute.Value != null)
                {
                    stringBuilder
                        .Append("=\"")
                        .Append(attribute.Value)
                        .Append('"');
                }
            }

            stringBuilder.Append('>');

            if (TagRenderMode == TagRenderMode.Normal)
            {
                Content.ForEach(c => { stringBuilder = c.Render(stringBuilder); });

                stringBuilder.Append("</").Append(TagName).Append('>');
            }

            return stringBuilder;
        }

        public sealed override string ToString()
        {
            return Render(new StringBuilder()).ToString();
        }
    }
}