using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportSrcsetAttribute : ITag { }

    public static class SrcsetAttribute
    {
        public static void AddSrcset(this SupportSrcsetAttribute tag, string srcset)
        {
            if (string.IsNullOrWhiteSpace(srcset)) { throw new ArgumentException(); }
            tag.TagBuilder.MergeAttribute("srcset", srcset);
        }
    }
}