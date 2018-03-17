using System;

namespace Tags
{
    public static class EnumExtensions
    {
        public static string LiteralValue(this Enum enumValue) => enumValue.ToString("f").ToLowerInvariant();
    }
}