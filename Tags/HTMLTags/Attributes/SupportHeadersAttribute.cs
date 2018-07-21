using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportHeadersAttribute : ITag { }

    public static class HeadersAttribute
    {
        public static void AddHeaders(this SupportHeadersAttribute tag, string headers)
        {
            if (string.IsNullOrWhiteSpace(headers)) { throw new ArgumentException(); }
            tag.AddAttribute("headers", headers);
        }
    }
}