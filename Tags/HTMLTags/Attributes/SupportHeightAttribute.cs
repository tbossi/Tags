using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportHeightAttribute : ITag { }

    public static class HeightAttribute
    {
        public static void AddHeight(this SupportHeightAttribute tag, int height)
        {
            if (height < 0) { throw new ArgumentException(); }
            tag.AddAttribute("height", height.ToString());
        }
    }
}