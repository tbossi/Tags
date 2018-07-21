using System.Web.Mvc;

namespace Tags.Tests.Acceptance
{
    public static class HTMLTestSamples
    {
        public static HTMLTestSample[] Samples;

        private const string _class1 = "wrapper";
        private const string _class2 = "xl-12";
        private const string _class3 = "qwerty";
        private const string _class4 = "container";
        private const string _id = "wrapperId";
        private const string _innerText1 = "Some text inside a <p> tag";
        private const string _innerText2 = "Click to open this link";
        private const string _innerText3 = "This is a cool way to build HTML!";
        private const string _link1 = "https://just.a.link";
        private const string _link2 = "https://link.to/script.js";
        private const string _value = "value";

        static HTMLTestSamples()
        {
            Samples = new[] {
                new HTMLTestSample
                { HTMLBuilderVersionGenerator = HTMLBuilder0, TagBuilderVersionGenerator = TagBuilder0, StringVersion = String0() }
            };
        }

        private static TagBuilder TagBuilder0()
        {
            var p = new TagBuilder("p");
            p.SetInnerText(_innerText1);

            var a = new TagBuilder("a");
            a.MergeAttribute("href", _link1);
            a.AddCssClass(_class3);
            a.SetInnerText(_innerText2);

            var quote = new TagBuilder("blockquote");
            quote.SetInnerText(_innerText3);

            var container = new TagBuilder("div") { InnerHtml = quote.ToString() };
            container.AddCssClass(_class4);
            container.MergeAttribute("data-key", _value);

            var wrapper = new TagBuilder("div") { InnerHtml = p.ToString() + a + container };
            wrapper.AddCssClass(_class1);
            wrapper.AddCssClass(_class2);
            wrapper.GenerateId(_id);

            var script = new TagBuilder("script");
            script.MergeAttribute("src", _link2);

            var body = new TagBuilder("body") { InnerHtml = wrapper.ToString() + script };
            var head = new TagBuilder("head") { InnerHtml = new TagBuilder("meta").ToString(TagRenderMode.StartTag) };
            var html = new TagBuilder("html") { InnerHtml = head.ToString() + body };

            return html;
        }

        private static HTMLBuilder HTMLBuilder0()
        {
            var doc = HTMLBuilder.Tag
                .Html()
                    .Head()
                        .Meta().End()
                    .End()
                    .Body()
                        .Div().Class(_class2, _class1).Id(_id)
                            .P().InnerText(_innerText1).End()
                            .A(_link1).Class(_class3).InnerText(_innerText2).End()
                            .Div().Class(_class4).Data("key", _value)
                                .Blockquote().InnerText(_innerText3).End()
                            .End()
                        .End()
                        .ExternalScript(_link2).End()
                    .End()
                .End();

            return doc;
        }

        private static string String0()
        {
            return
            "<html><head><meta></head>" +
            "<body><div class=\"xl-12 wrapper\" id=\"wrapperId\"><p>Some text inside a &lt;p&gt; tag</p>" +
            "<a class=\"qwerty\" href=\"https://just.a.link\">Click to open this link</a>" +
            "<div class=\"container\" data-key=\"value\"><blockquote>This is a cool way to build HTML!</blockquote></div>" +
            "</div><script src=\"https://link.to/script.js\"></script></body></html>";
        }
    }
}