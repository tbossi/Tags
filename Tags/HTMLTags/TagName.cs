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


        public static TagName Area => new TagName("area");

        public static TagName Audio => new TagName("audio");

        public static TagName Button => new TagName("button");

        public static TagName Data => new TagName("data");

        public static TagName Del => new TagName("del");
        public static TagName Details => new TagName("details");

        public static TagName Element => new TagName("element");

        public static TagName Embed => new TagName("embed");
        public static TagName Fieldset => new TagName("fieldset");

        public static TagName Form => new TagName("form");

        public static TagName Html => new TagName("html");
        public static TagName Iframe => new TagName("iframe");
        public static TagName Img => new TagName("img");
        public static TagName Input => new TagName("input");
        public static TagName Ins => new TagName("ins");

        public static TagName Label => new TagName("label");

        public static TagName Li => new TagName("li");
        public static TagName Link => new TagName("link");

        public static TagName Map => new TagName("map");

        public static TagName Meta => new TagName("meta");
        public static TagName Meter => new TagName("meter");

        public static TagName Object => new TagName("object");
        public static TagName Ol => new TagName("ol");
        public static TagName Optgroup => new TagName("optgroup");
        public static TagName Option => new TagName("option");
        public static TagName Output => new TagName("output");

        public static TagName Param => new TagName("param");

        public static TagName Progress => new TagName("progress");
        public static TagName Q => new TagName("q");

        public static TagName Script => new TagName("script");

        public static TagName Select => new TagName("select");

        public static TagName Source => new TagName("source");

        public static TagName Style => new TagName("style");

        public static TagName Td => new TagName("td");
        public static TagName Textarea => new TagName("textarea");
        public static TagName Th => new TagName("th");
        public static TagName Time => new TagName("time");
        public static TagName Track => new TagName("track");
        public static TagName Video => new TagName("video");
        public static TagName Wbr => new TagName("wbr");
    }
}