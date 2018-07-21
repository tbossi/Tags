namespace Tags.HTMLTags.Attributes
{
    public interface SupportReadonlyAttribute : ITag { }

    public static class ReadonlyAttribute
    {
        public static void AddReadonly(this SupportReadonlyAttribute tag)
        {
            tag.AddAttribute("readonly", "readonly");
        }
    }
}