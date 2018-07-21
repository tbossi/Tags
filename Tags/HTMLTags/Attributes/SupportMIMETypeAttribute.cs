using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportMIMETypeAttribute : ITag { }

    public static class MIMETypeAttribute
    {
        public static void AddType(this SupportMIMETypeAttribute tag, string type)
        {
            if (string.IsNullOrWhiteSpace(type)) { throw new ArgumentException(); }
            tag.AddAttribute("type", type);
        }
    }
}