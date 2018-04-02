using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportRowspanAttribute : ITag { }

    public static class RowspanValueAttribute
    {
        public static void AddRowspan(this SupportRowspanAttribute tag, int value)
        {
            if (value < 0) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("rowspan", value.ToString());
        }
    }
}