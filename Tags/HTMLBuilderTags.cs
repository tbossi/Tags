using System;
using System.Web.Mvc;
using Tags.Exception;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;

namespace Tags
{
    public static class HTMLBuilderTags
    {
        public static HTMLBuilder AddTagIfAllowed<T>(HTMLBuilder builder, T tagToAdd) where T : Tag
        {
            if (builder.CurrentOpenTag == null)
            {
                StoreTag(builder, tagToAdd);
                return builder;
            }

            StoreTag(builder, tagToAdd);
            return builder;
            //throw new ArgumentException($"Cannot place {tagToAdd} inside {builder.CurrentOpenTag}");
        }

        private static void StoreTag<T>(HTMLBuilder builder, T tagToAdd) where T : Tag
        {
            builder.StoreTag(tagToAdd);
            if (tagToAdd.TagRenderMode != TagRenderMode.Normal)
            {
                builder.End();
            }
        }

        public static HTMLBuilder A(this HTMLBuilder builder, string href) => AddTagIfAllowed(builder, new A(href));
        public static HTMLBuilder Abbr(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Abbr());
        public static HTMLBuilder Address(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Address());
        public static HTMLBuilder Article(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Article());
        public static HTMLBuilder Aside(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Aside());
        public static HTMLBuilder B(this HTMLBuilder builder) => AddTagIfAllowed(builder, new B());
        public static HTMLBuilder Base(this HTMLBuilder builder, string href, Target? target = null) => AddTagIfAllowed(builder, new Base(href, target));
        public static HTMLBuilder Base(this HTMLBuilder builder, Target target) => AddTagIfAllowed(builder, new Base(target));
        public static HTMLBuilder Bdi(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Bdi());
        public static HTMLBuilder Bdo(this HTMLBuilder builder, Dir dir) => AddTagIfAllowed(builder, new Bdo(dir));
        public static HTMLBuilder Blockquote(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Blockquote());
        public static HTMLBuilder Body(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Body());
        public static HTMLBuilder Br(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Br());
        public static HTMLBuilder Canvas(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Canvas());
        public static HTMLBuilder Caption(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Caption());
        public static HTMLBuilder Col(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Col());
        public static HTMLBuilder Colgroup(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Colgroup());
        public static HTMLBuilder Cite(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Cite());
        public static HTMLBuilder Code(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Code());
        public static HTMLBuilder Datalist(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Datalist());
        public static HTMLBuilder Dd(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Dd());
        public static HTMLBuilder Del(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Del());
        public static HTMLBuilder Dfn(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Dfn());
        public static HTMLBuilder Div(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Div());
        public static HTMLBuilder Dl(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Dl());
        public static HTMLBuilder Dt(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Dt());
        public static HTMLBuilder Em(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Em());
        public static HTMLBuilder Embed(this HTMLBuilder builder, string src) => AddTagIfAllowed(builder, new Embed(src));
        public static HTMLBuilder Figcaption(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Figcaption());
        public static HTMLBuilder Figure(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Figure());
        public static HTMLBuilder Footer(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Footer());
        public static HTMLBuilder H1(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H1());
        public static HTMLBuilder H2(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H2());
        public static HTMLBuilder H3(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H3());
        public static HTMLBuilder H4(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H4());
        public static HTMLBuilder H5(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H5());
        public static HTMLBuilder H6(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H6());
        public static HTMLBuilder Head(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Head());
        public static HTMLBuilder Html(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Html());
        public static HTMLBuilder I(this HTMLBuilder builder) => AddTagIfAllowed(builder, new I());
        public static HTMLBuilder Ins(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Ins());
        public static HTMLBuilder Iframe(this HTMLBuilder builder, string src) => AddTagIfAllowed(builder, new Iframe(src));
        public static HTMLBuilder Kbd(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Kbd());
        public static HTMLBuilder Legend(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Legend());
        public static HTMLBuilder Li(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Li());
        public static HTMLBuilder Main(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Main());
        public static HTMLBuilder Mark(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Mark());
        public static HTMLBuilder Nav(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Nav());
        public static HTMLBuilder Noscript(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Noscript());
        public static HTMLBuilder P(this HTMLBuilder builder) => AddTagIfAllowed(builder, new P());
        public static HTMLBuilder Picture(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Picture());
        public static HTMLBuilder Pre(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Pre());
        public static HTMLBuilder Q(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Q());
        public static HTMLBuilder Rp(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Rp());
        public static HTMLBuilder Rt(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Rt());
        public static HTMLBuilder Ruby(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Ruby());
        public static HTMLBuilder S(this HTMLBuilder builder) => AddTagIfAllowed(builder, new S());
        public static HTMLBuilder Samp(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Samp());
        public static HTMLBuilder Section(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Section());
        public static HTMLBuilder Small(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Small());
        public static HTMLBuilder Span(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Span());
        public static HTMLBuilder Strong(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Strong());
        public static HTMLBuilder Sub(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Sub());
        public static HTMLBuilder Summary(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Summary());
        public static HTMLBuilder Sup(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Sup());
        public static HTMLBuilder Table(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Table());
        public static HTMLBuilder Tbody(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Tbody());
        public static HTMLBuilder Template(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Template());
        public static HTMLBuilder Tfoot(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Tfoot());
        public static HTMLBuilder Thead(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Thead());
        public static HTMLBuilder Time(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Time());
        public static HTMLBuilder Title(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Title());
        public static HTMLBuilder Tr(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Tr());
        public static HTMLBuilder U(this HTMLBuilder builder) => AddTagIfAllowed(builder, new U());
        public static HTMLBuilder Ul(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Ul());
        public static HTMLBuilder Var(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Var());
        public static HTMLBuilder Wbr(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Wbr());
    }

    public static class HTMLBuilderAttributes
    {
        public static HTMLBuilder AddAttribute<T>(HTMLBuilder builder, string attributeName,
            Action<T> attributeAdder)
        {
            if (builder.CurrentOpenTag is T tag)
            {
                attributeAdder.Invoke(tag);
                return builder;
            }

            throw new InvalidAttribute(attributeName, builder.CurrentOpenTag);
        }

        public static HTMLBuilder Cite(this HTMLBuilder builder, string cite)
            => AddAttribute<SupportCiteAttribute>(builder, "cite", tag => tag.AddCite(cite));

        public static HTMLBuilder Datetime(this HTMLBuilder builder, DateTime datetime)
            => AddAttribute<SupportDatetimeAttribute>(builder, "datetime", tag => tag.AddDatetime(datetime));

        public static HTMLBuilder Download(this HTMLBuilder builder, string filename = "")
            => AddAttribute<A>(builder, "download", tag => tag.AddDownload(filename));

        public static HTMLBuilder Height(this HTMLBuilder builder, int height)
            => AddAttribute<SupportHeightAttribute>(builder, "height", tag => tag.AddHeight(height));

        public static HTMLBuilder Name(this HTMLBuilder builder, string name)
            => AddAttribute<SupportNameAttribute>(builder, "name", tag => tag.AddName(name));

        public static HTMLBuilder Rel(this HTMLBuilder builder, Rel rel)
            => AddAttribute<SupportRelAttribute>(builder, "rel", tag => tag.AddRel(rel));

        public static HTMLBuilder Sandbox(this HTMLBuilder builder, params Sandbox[] sandbox)
            => AddAttribute<Iframe>(builder, "sandbox", tag => tag.AddSandbox(sandbox));

        public static HTMLBuilder Span(this HTMLBuilder builder, int span)
            => AddAttribute<SupportSpanAttribute>(builder, "span", tag => tag.AddSpan(span));

        public static HTMLBuilder Srcdoc(this HTMLBuilder builder, string srcdoc)
            => AddAttribute<Iframe>(builder, "srcdoc", tag => tag.AddSrcdoc(srcdoc));

        public static HTMLBuilder Target(this HTMLBuilder builder, Target target)
            => AddAttribute<SupportTargetAttribute>(builder, "target", tag => tag.AddTarget(target));

        public static HTMLBuilder Type(this HTMLBuilder builder, string type)
            => AddAttribute<SupportMIMETypeAttribute>(builder, "type", tag => tag.AddType(type));

        public static HTMLBuilder Value(this HTMLBuilder builder, int value)
            => AddAttribute<SupportNumberValueAttribute>(builder, "value", tag => tag.AddValue(value));

        public static HTMLBuilder Width(this HTMLBuilder builder, int width)
            => AddAttribute<SupportWidthAttribute>(builder, "width", tag => tag.AddWidth(width));
    }
}