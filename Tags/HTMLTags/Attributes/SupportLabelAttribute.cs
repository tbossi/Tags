namespace Tags.HTMLTags.Attributes
{
    public interface SupportLabelAttribute : ITag { }

    public static class LabelAttribute
    {
        public static void AddLabel(this SupportLabelAttribute tag, string label)
        {
            tag.TagBuilder.MergeAttribute("label", label);
        }
    }
}