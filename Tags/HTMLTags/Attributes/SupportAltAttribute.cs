using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportAltAttribute : ITag { }
    
    public static class AltAttribute
    {
        public static void AddAlt(this SupportAltAttribute tag, string alt)
        {
            if (string.IsNullOrWhiteSpace(alt)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("alt", alt);
        }
    }
}