namespace Tags.HTMLTags.Attributes
{
    public interface SupportMultipleAttribute : ITag { }

    public static class MultipleAttribute
    {
        public static void AddMultiple(this SupportMultipleAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("multiple", "multiple");
        }
    }
}