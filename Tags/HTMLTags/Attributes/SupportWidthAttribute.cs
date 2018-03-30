using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportWidthAttribute : ITag { }

    public static class WidthAttribute
    {
        public static void AddWidth(this SupportWidthAttribute tag, int width)
        {
            if (width < 0) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("width", width.ToString());
        }
    }
}