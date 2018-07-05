using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportCharsetAttribute : ITag { }

    public static class CharsetAttribute
    {
        public static void AddCharset(this SupportCharsetAttribute tag, Charset charset)
        {
            tag.TagBuilder.MergeAttribute("charset", charset.LiteralValue());
        }
    }
}