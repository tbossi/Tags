namespace Tags.HTMLTags.Attributes
{
    public interface SupportLabelAttribute : ITag { }

    public static class LabelAttribute
    {
        public static void AddLabel(this SupportLabelAttribute tag, string label)
        {
            tag.AddAttribute("label", label);
        }
    }
}