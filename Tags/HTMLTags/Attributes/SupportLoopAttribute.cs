namespace Tags.HTMLTags.Attributes
{
    public interface SupportLoopAttribute : ITag { }

    public static class LoopAttribute
    {
        public static void AddLoop(this SupportLoopAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("loop", "loop");
        }
    }
}