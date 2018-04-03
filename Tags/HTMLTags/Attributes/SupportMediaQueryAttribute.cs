using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportMediaQueryAttribute : ITag { }

    public static class MediaQueryAttribute
    {
        public static void AddMedia(this SupportMediaQueryAttribute tag, string media)
        {
            if (string.IsNullOrWhiteSpace(media)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("media", media);
        }
    }
}