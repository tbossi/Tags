using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportUsemapAttribute : ITag { }

    public static class UsemapAttribute
    {
        public static void AddUsemap(this SupportUsemapAttribute tag, string id)
        {
            if (string.IsNullOrWhiteSpace(id)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("usemap", id);
        }
    }
}