namespace Tags.HTMLTags.Attributes
{
    public interface SupportAutofocusAttribute : ITag { }

    public static class AutofocusAttribute
    {
        public static void AddAutofocus(this SupportAutofocusAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("autofocus", "autofocus");
        }
    }
}