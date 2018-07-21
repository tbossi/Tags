using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportNumberValueAttribute : ITag { }

    public static class NumberValueAttribute
    {
        public static void AddValue(this SupportNumberValueAttribute tag, int value)
        {
            if (value < 0) { throw new ArgumentException(); }
            tag.AddAttribute("value", value.ToString());
        }
    }
}