using System;

namespace Tags.HTMLTags.Attributes
{
    public interface SupportDatetimeAttribute : ITag { }

    public static class DatetimeAttribute
    {
        public static void AddDatetime(this SupportDatetimeAttribute tag, DateTime datetime)
        {
            tag.AddAttribute("datetime", datetime.ToString("u"));
        }
    }
}