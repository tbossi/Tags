using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportForAttribute : ITag { }

    public static class ForAttribute
    {
        public static void AddFor(this SupportForAttribute tag, string id)
        {
            if (string.IsNullOrWhiteSpace(id)) { throw new ArgumentException(); }
            tag.AddAttribute("for", id);
        }
    }
}