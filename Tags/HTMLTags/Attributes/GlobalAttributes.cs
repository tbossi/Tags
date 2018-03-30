using System;
using System.Collections.Generic;

namespace Tags.HTMLTags.Attributes
{
    public static class GlobalAttributes
    {
        public static void AddId(this ITag tag, string id)
        {
            if (string.IsNullOrWhiteSpace(id)) { throw new ArgumentException(); }
            tag.TagBuilder.GenerateId(id);
        }

        public static void AddClasses(this ITag tag, params string[] classes)
        {
            foreach (var cl in new HashSet<string>(classes))
            {
                if (string.IsNullOrEmpty(cl))
                    continue;

                tag.TagBuilder.AddCssClass(cl);
            }
        }

        public static void AddData(this ITag tag, string key, string value)
        {
            if (string.IsNullOrWhiteSpace(key)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute($"data-{key}", value);
        }

        public static void AddTitle(this ITag tag, string title)
        {
            if (string.IsNullOrWhiteSpace(title)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("title", title);
        }
    }
}