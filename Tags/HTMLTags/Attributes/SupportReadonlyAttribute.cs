namespace Tags.HTMLTags.Attributes
{
    public interface SupportReadonlyAttribute : ITag { }

    public static class ReadonlyAttribute
    {
        public static void AddReadonly(this SupportReadonlyAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("readonly", "readonly");
        }
    }
}