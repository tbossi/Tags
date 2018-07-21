using System.Text;
using Tags.Encoders;

namespace Tags.HTMLTags
{
    public class Text : InnerHtml
    {
        private readonly string _text;
        private readonly StringEncoder _encoder;

        public Text(string text, StringEncoder encoder = null)
        {
            _text = text;
            _encoder = encoder ?? new ContentEncoder();
        }

        public StringBuilder Render(StringBuilder stringBuilder)
        {
            stringBuilder.Append(_encoder.Encode(_text));
            return stringBuilder;
        }

        public override string ToString()
        {
            return Render(new StringBuilder()).ToString();
        }

        public virtual bool Equals(Text other)
        {
            return _text == other._text && _encoder == other._encoder;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Equals((Text)obj);
        }
    }
}