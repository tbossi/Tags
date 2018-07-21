using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportSrcAttribute : ITag { }

    public static class SrcAttribute
    {
        public static void AddSrc(this SupportSrcAttribute tag, string src)
        {
            if (string.IsNullOrWhiteSpace(src)) { throw new ArgumentException(); }
            tag.AddAttribute("src", src);
        }
    }
}