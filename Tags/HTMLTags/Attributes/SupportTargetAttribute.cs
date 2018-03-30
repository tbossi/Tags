namespace Tags.HTMLTags.Attributes
{
    public interface SupportTargetAttribute : ITag { }

    public static class TargetAttribute
    {
        public static void AddTarget(this SupportTargetAttribute tag, Target target)
        {
            tag.TagBuilder.MergeAttribute("target", target.LiteralValue());
        }
    }
}