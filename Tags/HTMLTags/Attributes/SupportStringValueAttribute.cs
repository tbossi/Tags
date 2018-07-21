namespace Tags.HTMLTags.Attributes
{
    public interface SupportStringValueAttribute : ITag { }

    public static class StringValueAttribute
    {
        public static void AddValue(this SupportStringValueAttribute tag, string value)
        {
            tag.AddAttribute("value", value);
        }
    }
}