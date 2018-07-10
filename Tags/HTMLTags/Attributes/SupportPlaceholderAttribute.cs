namespace Tags.HTMLTags.Attributes
{
    public interface SupportPlaceholderAttribute : ITag { }

    public static class PlaceholderAttribute
    {
        public static void AddPlaceholder(this SupportPlaceholderAttribute tag, string placeholder)
        {
            tag.TagBuilder.MergeAttribute("placeholder", placeholder);
        }
    }
}