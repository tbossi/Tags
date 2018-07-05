namespace Tags.HTMLTags.Attributes
{
    public interface SupportDisabledAttribute : ITag { }

    public static class DisabledAttribute
    {
        public static void AddDisabled(this SupportDisabledAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("disabled", "disabled");
        }
    }
}