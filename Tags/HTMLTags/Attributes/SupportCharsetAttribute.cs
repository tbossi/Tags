using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportCharsetAttribute : ITag { }

    public static class CharsetAttribute
    {
        public static void AddCharset(this SupportCharsetAttribute tag, Charset charset)
        {
            tag.AddAttribute("charset", charset.LiteralValue());
        }
    }
}