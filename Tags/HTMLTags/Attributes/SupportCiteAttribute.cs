using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportCiteAttribute : ITag { }

    public static class CiteAttribute
    {
        public static void AddCite(this SupportCiteAttribute tag, string cite)
        {
            if (string.IsNullOrWhiteSpace(cite)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("cite", cite);
        }
    }
}