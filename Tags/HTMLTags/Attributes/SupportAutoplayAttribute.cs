namespace Tags.HTMLTags.Attributes
{
    public interface SupportAutoplayAttribute : ITag { }

    public static class AutoplayAttribute
    {
        public static void AddAutoplay(this SupportAutoplayAttribute tag)
        {
            tag.AddAttribute("autoplay", "autoplay");
        }
    }
}