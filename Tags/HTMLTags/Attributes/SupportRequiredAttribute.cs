namespace Tags.HTMLTags.Attributes
{
    public interface SupportRequiredAttribute : ITag { }

    public static class RequiredAttribute
    {
        public static void AddRequired(this SupportRequiredAttribute tag)
        {
            tag.AddAttribute("required", "required");
        }
    }
}