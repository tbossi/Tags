namespace Tags.HTMLTags.Attributes
{
    public interface SupportDownloadAttribute : ITag { }

    public static class DownloadAttribute
    {
        public static void AddDownload(this SupportDownloadAttribute tag, string newFileName)
        {
            tag.AddAttribute("download", newFileName);
        }
    }
}