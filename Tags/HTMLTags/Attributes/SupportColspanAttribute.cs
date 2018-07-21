using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportColspanAttribute : ITag { }

    public static class ColspanValueAttribute
    {
        public static void AddColspan(this SupportColspanAttribute tag, int value)
        {
            if (value < 0) { throw new ArgumentException(); }
            tag.AddAttribute("colspan", value.ToString());
        }
    }
}