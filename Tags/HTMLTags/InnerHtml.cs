using System.Text;

namespace Tags.HTMLTags
{
    public interface InnerHtml
    {
        StringBuilder Render(StringBuilder stringBuilder);
    }
}