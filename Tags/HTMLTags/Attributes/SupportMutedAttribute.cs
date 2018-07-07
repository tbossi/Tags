namespace Tags.HTMLTags.Attributes
{
    public interface SupportMutedAttribute : ITag { }

    public static class MutedAttribute
    {
        public static void AddMuted(this SupportMutedAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("muted", "muted");
        }
    }
}