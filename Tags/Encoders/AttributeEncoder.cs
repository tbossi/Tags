using System.Web;

namespace Tags.Encoders
{
    public class AttributeEncoder : StringEncoder
    {
        public string Encode(string original)
        {
            return original == null ? original : HttpUtility.HtmlAttributeEncode(original);
        }
    }
}