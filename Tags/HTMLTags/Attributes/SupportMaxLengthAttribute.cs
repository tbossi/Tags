using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportMaxLengthAttribute : ITag { }

    public static class MaxLengthAttribute
    {
        public static void AddMaxLength(this SupportMaxLengthAttribute tag, int maxlength)
        {
            if (maxlength < 0) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("maxlength", maxlength.ToString());
        }
    }
}