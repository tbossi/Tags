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

        //public static TagName A => new TagName("a");
        //public static TagName Abbr => new TagName("abbr");
        //public static TagName Address => new TagName("address");
        public static TagName Area => new TagName("area");
        //public static TagName Article => new TagName("article");
        //public static TagName Aside => new TagName("aside");
        public static TagName Audio => new TagName("audio");
        //public static TagName B => new TagName("b");
        //public static TagName Base => new TagName("base");
        //public static TagName Bdi => new TagName("bdi");
        //public static TagName Bdo => new TagName("bdo");
        public static TagName Blink => new TagName("blink");
        public static TagName Blockquote => new TagName("blockquote");
        //public static TagName Body => new TagName("body");
        public static TagName Br => new TagName("br");
        public static TagName Button => new TagName("button");
        public static TagName Canvas => new TagName("canvas");
        public static TagName Caption => new TagName("caption");
        public static TagName Cite => new TagName("cite");
        public static TagName Code => new TagName("code");
        public static TagName Col => new TagName("col");
        public static TagName Colgroup => new TagName("colgroup");
        public static TagName Command => new TagName("command");
        public static TagName Data => new TagName("data");
        public static TagName Datalist => new TagName("datalist");
        public static TagName Dd => new TagName("dd");
        public static TagName Del => new TagName("del");
        public static TagName Details => new TagName("details");
        public static TagName Dfn => new TagName("dfn");
        //public static TagName Div => new TagName("div");
        public static TagName Dl => new TagName("dl");
        public static TagName Dt => new TagName("dt");
        public static TagName Element => new TagName("element");
        public static TagName Em => new TagName("em");
        public static TagName Embed => new TagName("embed");
        public static TagName Fieldset => new TagName("fieldset");
        public static TagName Figcaption => new TagName("figcaption");
        public static TagName Figure => new TagName("figure");
        public static TagName Footer => new TagName("footer");
        public static TagName Form => new TagName("form");
        public static TagName H1 => new TagName("h1");
        public static TagName H2 => new TagName("h2");
        public static TagName H3 => new TagName("h3");
        public static TagName H4 => new TagName("h4");
        public static TagName H5 => new TagName("h5");
        public static TagName H6 => new TagName("h6");
        public static TagName Head => new TagName("head");
        public static TagName Header => new TagName("header");
        public static TagName Hr => new TagName("hr");
        public static TagName Html => new TagName("html");
        public static TagName I => new TagName("i");
        public static TagName Iframe => new TagName("iframe");
        public static TagName Img => new TagName("img");
        public static TagName Input => new TagName("input");
        public static TagName Ins => new TagName("ins");
        public static TagName Kbd => new TagName("kbd");
        public static TagName Label => new TagName("label");
        public static TagName Legend => new TagName("legend");
        public static TagName Li => new TagName("li");
        public static TagName Link => new TagName("link");
        public static TagName Main => new TagName("main");
        public static TagName Map => new TagName("map");
        public static TagName Mark => new TagName("mark");
        public static TagName Marquee => new TagName("marquee");
        public static TagName Meta => new TagName("meta");
        public static TagName Meter => new TagName("meter");
        public static TagName Nav => new TagName("nav");
        public static TagName Noscript => new TagName("noscript");
        public static TagName Object => new TagName("object");
        public static TagName Ol => new TagName("ol");
        public static TagName Optgroup => new TagName("optgroup");
        public static TagName Option => new TagName("option");
        public static TagName Output => new TagName("output");
        //public static TagName P => new TagName("p");
        public static TagName Param => new TagName("param");
        public static TagName Picture => new TagName("picture");
        public static TagName Pre => new TagName("pre");
        public static TagName Progress => new TagName("progress");
        public static TagName Q => new TagName("q");
        public static TagName Rp => new TagName("rp");
        public static TagName Rt => new TagName("rt");
        public static TagName Rtc => new TagName("rtc");
        public static TagName Ruby => new TagName("ruby");
        public static TagName S => new TagName("s");
        public static TagName Samp => new TagName("samp");
        public static TagName Script => new TagName("script");
        public static TagName Section => new TagName("section");
        public static TagName Select => new TagName("select");
        public static TagName Slot => new TagName("slot");
        public static TagName Small => new TagName("small");
        public static TagName Source => new TagName("source");
        public static TagName Span => new TagName("span");
        public static TagName Strong => new TagName("strong");
        public static TagName Style => new TagName("style");
        public static TagName Sub => new TagName("sub");
        public static TagName Summary => new TagName("summary");
        public static TagName Sup => new TagName("sup");
        public static TagName Table => new TagName("table");
        public static TagName Tbody => new TagName("tbody");
        public static TagName Td => new TagName("td");
        public static TagName Template => new TagName("template");
        public static TagName Textarea => new TagName("textarea");
        public static TagName Tfoot => new TagName("tfoot");
        public static TagName Th => new TagName("th");
        public static TagName Thead => new TagName("thead");
        public static TagName Time => new TagName("time");
        public static TagName Title => new TagName("title");
        public static TagName Tr => new TagName("tr");
        public static TagName Track => new TagName("track");
        public static TagName U => new TagName("u");
        public static TagName Ul => new TagName("ul");
        public static TagName Var => new TagName("var");
        public static TagName Video => new TagName("video");
        public static TagName Wbr => new TagName("wbr");
    }
}