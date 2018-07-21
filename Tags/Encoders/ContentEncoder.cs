using System.Web;

namespace Tags.Encoders
{
    public class ContentEncoder : StringEncoder
    {
        public string Encode(string original)
        {
            return HttpUtility.HtmlEncode(original);
        }
    }
}