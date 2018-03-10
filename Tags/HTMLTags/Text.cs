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
    }
}