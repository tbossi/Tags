using System;

namespace Tags.HTMLTags
{
    [Obsolete("Remove when every tag is implemented")]
    public class TagName
    {
        public readonly string Name;

        public TagName(string name)
        {
            Name = name;
        }

        public static TagName Object => new TagName("object");
        public static TagName Ol => new TagName("ol");
        public static TagName Optgroup => new TagName("optgroup");
        public static TagName Option => new TagName("option");
        public static TagName Output => new TagName("output");

        public static TagName Param => new TagName("param");

        public static TagName Progress => new TagName("progress");

        public static TagName Select => new TagName("select");

        public static TagName Source => new TagName("source");

        public static TagName Style => new TagName("style");

        public static TagName Textarea => new TagName("textarea");

        public static TagName Track => new TagName("track");
        public static TagName Video => new TagName("video");
    }
}