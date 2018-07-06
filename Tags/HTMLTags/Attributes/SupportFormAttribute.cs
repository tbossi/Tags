using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportFormAttribute : ITag { }

    public static class FormAttribute
    {
        public static void AddForm(this SupportFormAttribute tag, string id)
        {
            if (string.IsNullOrWhiteSpace(id)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("form", id);
        }
    }
}