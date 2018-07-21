using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportSpanAttribute : ITag { }

    public static class SpanAttribute
    {
        public static void AddSpan(this SupportSpanAttribute tag, int span)
        {
            if (span < 0) { throw new ArgumentException(); }
            tag.AddAttribute("span", span.ToString());
        }
    }
}