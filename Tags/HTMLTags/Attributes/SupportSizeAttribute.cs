using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportSizeAttribute : ITag { }

    public static class SizeAttribute
    {
        public static void AddSize(this SupportSizeAttribute tag, int value)
        {
            if (value < 0) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("size", value.ToString());
        }
    }
}