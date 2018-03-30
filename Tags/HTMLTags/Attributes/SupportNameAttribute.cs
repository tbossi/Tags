using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportNameAttribute : ITag {}

    public static class NameAttribute
    {
        public static void AddName(this SupportNameAttribute tag, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("name", name);
        }
    }
}