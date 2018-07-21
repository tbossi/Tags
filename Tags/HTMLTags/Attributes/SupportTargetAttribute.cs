namespace Tags.HTMLTags.Attributes
{
    public interface SupportTargetAttribute : ITag { }

    public static class TargetAttribute
    {
        public static void AddTarget(this SupportTargetAttribute tag, Target target)
        {
            tag.AddAttribute("target", target.LiteralValue());
        }
    }
}