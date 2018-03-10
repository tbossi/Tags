using System.Web;
using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Text : InnerHtml
    {
        private readonly string _text;

        public Text(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return HttpUtility.HtmlEncode(_text);
        }

        public bool Equals(Text other)
        {
            return _text == other._text;
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