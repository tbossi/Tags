using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportMIMETypeAttribute : ITag { }

    public static class MIMETypeAttribute
    {
        public static void AddType(this SupportMIMETypeAttribute tag, string type)
        {
            if (string.IsNullOrEmpty(type)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("type", type);
        }
    }
}