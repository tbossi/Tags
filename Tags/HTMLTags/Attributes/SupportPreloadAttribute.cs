namespace Tags.HTMLTags.Attributes
{
    public interface SupportPreloadAttribute : ITag { }

    public static class PreloadAttribute
    {
        public static void AddPreload(this SupportPreloadAttribute tag, Preload preload)
        {
            tag.AddAttribute("preload", preload.LiteralValue());
        }
    }
}