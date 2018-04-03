using System;
using System.Web.Mvc;
using Tags.Exception;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;

namespace Tags
{
    public static class HTMLBuilderUtilities
    {
        public static HTMLBuilder<T, HTMLBuilder<X, Y>> AddNormalTagIfAllowed<T, X, Y>(HTMLBuilder<X, Y> builder, T tagToAdd)
            where T : Tag
            where X : Tag
            where Y : HTMLBuilder
        {
            if (builder.CurrentTag == null)
            {
                return StoreNormalTag(builder, tagToAdd);
            }

            //if tag is inside something
            return StoreNormalTag(builder, tagToAdd);
        }

        private static HTMLBuilder<T, HTMLBuilder<X, Y>> StoreNormalTag<T, X, Y>(HTMLBuilder<X, Y> builder, T tagToAdd)
            where T : Tag
            where X : Tag
            where Y : HTMLBuilder
        {
            return builder.StoreTag(tagToAdd);
        }

        public static HTMLBuilder<X, Y> AddAutocloseTagIfAllowed<T, X, Y>(HTMLBuilder<X, Y> builder, T tagToAdd)
            where T : Tag
            where X : Tag
            where Y : HTMLBuilder
        {
            if (builder.CurrentTag == null)
            {
                return StoreAutocloseTag(builder, tagToAdd);
            }

            //if tag is inside something
            return StoreAutocloseTag(builder, tagToAdd);
        }

        private static HTMLBuilder<X, Y> StoreAutocloseTag<T, X, Y>(HTMLBuilder<X, Y> builder, T tagToAdd)
            where T : Tag
            where X : Tag
            where Y : HTMLBuilder
        {
            return builder.StoreTag(tagToAdd).End();
        }
    }

    public static class HTMLBuilderTags
    {
        public static HTMLBuilder<A, HTMLBuilder<X, Y>> A<X, Y>(this HTMLBuilder<X, Y> builder, string href)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new A(href));

        public static HTMLBuilder<Abbr, HTMLBuilder<X, Y>> Abbr<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Abbr());

        public static HTMLBuilder<Address, HTMLBuilder<X, Y>> Address<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Address());

        public static HTMLBuilder<Article, HTMLBuilder<X, Y>> Article<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Article());

        public static HTMLBuilder<Aside, HTMLBuilder<X, Y>> Aside<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Aside());

        public static HTMLBuilder<B, HTMLBuilder<X, Y>> B<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new B());

        public static HTMLBuilder<X, Y> Base<X, Y>(this HTMLBuilder<X, Y> builder, string href, Target? target = null)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Base(href, target));

        public static HTMLBuilder<X, Y> Base<X, Y>(this HTMLBuilder<X, Y> builder, Target target)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Base(target));

        public static HTMLBuilder<Bdi, HTMLBuilder<X, Y>> Bdi<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Bdi());

        public static HTMLBuilder<Bdo, HTMLBuilder<X, Y>> Bdo<X, Y>(this HTMLBuilder<X, Y> builder, Dir dir)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Bdo(dir));

        public static HTMLBuilder<Blockquote, HTMLBuilder<X, Y>> Blockquote<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Blockquote());

        public static HTMLBuilder<Body, HTMLBuilder<X, Y>> Body<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Body());

        public static HTMLBuilder<X, Y> Br<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Br());

        public static HTMLBuilder<Canvas, HTMLBuilder<X, Y>> Canvas<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Canvas());

        public static HTMLBuilder<Caption, HTMLBuilder<X, Y>> Caption<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Caption());

        public static HTMLBuilder<Col, HTMLBuilder<X, Y>> Col<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Col());

        public static HTMLBuilder<Colgroup, HTMLBuilder<X, Y>> Colgroup<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Colgroup());

        public static HTMLBuilder<Cite, HTMLBuilder<X, Y>> Cite<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Cite());

        public static HTMLBuilder<Code, HTMLBuilder<X, Y>> Code<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Code());

        public static HTMLBuilder<Data, HTMLBuilder<X, Y>> Data<X, Y>(this HTMLBuilder<X, Y> builder, string value)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Data(value));

        public static HTMLBuilder<Datalist, HTMLBuilder<X, Y>> Datalist<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Datalist());

        public static HTMLBuilder<Dd, HTMLBuilder<X, Y>> Dd<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Dd());

        public static HTMLBuilder<Del, HTMLBuilder<X, Y>> Del<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Del());

        public static HTMLBuilder<Details, HTMLBuilder<X, Y>> Details<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Details());

        public static HTMLBuilder<Dfn, HTMLBuilder<X, Y>> Dfn<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Dfn());

        public static HTMLBuilder<Div, HTMLBuilder<X, Y>> Div<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Div());

        public static HTMLBuilder<Dl, HTMLBuilder<X, Y>> Dl<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Dl());

        public static HTMLBuilder<Dt, HTMLBuilder<X, Y>> Dt<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Dt());

        public static HTMLBuilder<Em, HTMLBuilder<X, Y>> Em<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Em());

        public static HTMLBuilder<X, Y> Embed<X, Y>(this HTMLBuilder<X, Y> builder, string src)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Embed(src));

        public static HTMLBuilder<Figcaption, HTMLBuilder<X, Y>> Figcaption<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Figcaption());

        public static HTMLBuilder<Figure, HTMLBuilder<X, Y>> Figure<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Figure());

        public static HTMLBuilder<Footer, HTMLBuilder<X, Y>> Footer<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Footer());

        public static HTMLBuilder<H1, HTMLBuilder<X, Y>> H1<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new H1());

        public static HTMLBuilder<H2, HTMLBuilder<X, Y>> H2<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new H2());

        public static HTMLBuilder<H3, HTMLBuilder<X, Y>> H3<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new H3());

        public static HTMLBuilder<H4, HTMLBuilder<X, Y>> H4<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new H4());

        public static HTMLBuilder<H5, HTMLBuilder<X, Y>> H5<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new H5());

        public static HTMLBuilder<H6, HTMLBuilder<X, Y>> H6<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new H6());

        public static HTMLBuilder<Head, HTMLBuilder<X, Y>> Head<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Head());

        public static HTMLBuilder<Html, HTMLBuilder<X, Y>> Html<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Html());

        public static HTMLBuilder<I, HTMLBuilder<X, Y>> I<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new I());

        public static HTMLBuilder<Ins, HTMLBuilder<X, Y>> Ins<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Ins());

        public static HTMLBuilder<Iframe, HTMLBuilder<X, Y>> Iframe<X, Y>(this HTMLBuilder<X, Y> builder, string src)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Iframe(src));

        public static HTMLBuilder<Kbd, HTMLBuilder<X, Y>> Kbd<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Kbd());

        public static HTMLBuilder<Legend, HTMLBuilder<X, Y>> Legend<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Legend());

        public static HTMLBuilder<Li, HTMLBuilder<X, Y>> Li<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Li());

        public static HTMLBuilder<X, Y> Link<X, Y>(this HTMLBuilder<X, Y> builder, string href)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Link(href));

        public static HTMLBuilder<Main, HTMLBuilder<X, Y>> Main<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Main());

        public static HTMLBuilder<Map, HTMLBuilder<X, Y>> Map<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Map());

        public static HTMLBuilder<Mark, HTMLBuilder<X, Y>> Mark<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Mark());

        public static HTMLBuilder<X, Y> Meta<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Meta());

        public static HTMLBuilder<Nav, HTMLBuilder<X, Y>> Nav<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Nav());

        public static HTMLBuilder<Noscript, HTMLBuilder<X, Y>> Noscript<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Noscript());

        public static HTMLBuilder<P, HTMLBuilder<X, Y>> P<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new P());

        public static HTMLBuilder<Picture, HTMLBuilder<X, Y>> Picture<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Picture());

        public static HTMLBuilder<Pre, HTMLBuilder<X, Y>> Pre<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Pre());

        public static HTMLBuilder<Q, HTMLBuilder<X, Y>> Q<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Q());

        public static HTMLBuilder<Rp, HTMLBuilder<X, Y>> Rp<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Rp());

        public static HTMLBuilder<Rt, HTMLBuilder<X, Y>> Rt<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Rt());

        public static HTMLBuilder<Ruby, HTMLBuilder<X, Y>> Ruby<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Ruby());

        public static HTMLBuilder<S, HTMLBuilder<X, Y>> S<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new S());

        public static HTMLBuilder<Samp, HTMLBuilder<X, Y>> Samp<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Samp());

        public static HTMLBuilder<X, Y> ExternalScript<X, Y>(this HTMLBuilder<X, Y> builder, string src)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new ExternalScript(src));
            
        public static HTMLBuilder<X, Y> InlineScript<X, Y>(this HTMLBuilder<X, Y> builder, string scriptSource)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new InlineScript(scriptSource));

        public static HTMLBuilder<Section, HTMLBuilder<X, Y>> Section<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Section());

        public static HTMLBuilder<Small, HTMLBuilder<X, Y>> Small<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Small());

        public static HTMLBuilder<Span, HTMLBuilder<X, Y>> Span<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Span());

        public static HTMLBuilder<Strong, HTMLBuilder<X, Y>> Strong<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Strong());

        public static HTMLBuilder<Sub, HTMLBuilder<X, Y>> Sub<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Sub());

        public static HTMLBuilder<Summary, HTMLBuilder<X, Y>> Summary<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Summary());

        public static HTMLBuilder<Sup, HTMLBuilder<X, Y>> Sup<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Sup());

        public static HTMLBuilder<Table, HTMLBuilder<X, Y>> Table<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Table());

        public static HTMLBuilder<Tbody, HTMLBuilder<X, Y>> Tbody<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Tbody());

        public static HTMLBuilder<Td, HTMLBuilder<X, Y>> Td<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Td());

        public static HTMLBuilder<Template, HTMLBuilder<X, Y>> Template<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Template());

        public static HTMLBuilder<Tfoot, HTMLBuilder<X, Y>> Tfoot<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Tfoot());

        public static HTMLBuilder<Th, HTMLBuilder<X, Y>> Th<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Th());

        public static HTMLBuilder<Thead, HTMLBuilder<X, Y>> Thead<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Thead());

        public static HTMLBuilder<Time, HTMLBuilder<X, Y>> Time<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Time());

        public static HTMLBuilder<Title, HTMLBuilder<X, Y>> Title<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Title());

        public static HTMLBuilder<Tr, HTMLBuilder<X, Y>> Tr<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Tr());

        public static HTMLBuilder<U, HTMLBuilder<X, Y>> U<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new U());

        public static HTMLBuilder<Ul, HTMLBuilder<X, Y>> Ul<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Ul());

        public static HTMLBuilder<Var, HTMLBuilder<X, Y>> Var<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddNormalTagIfAllowed(builder, new Var());

        public static HTMLBuilder<X, Y> Wbr<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Tag
            where Y : HTMLBuilder
            => HTMLBuilderUtilities.AddAutocloseTagIfAllowed(builder, new Wbr());
    }

    public static class HTMLBuilderAttributes
    {
        public static HTMLBuilder<X, Y> Charset<X, Y>(this HTMLBuilder<X, Y> builder, string charset)
            where X : Tag, SupportCharsetAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCharset(charset);
            return builder;
        }

        public static HTMLBuilder<X, Y> Cite<X, Y>(this HTMLBuilder<X, Y> builder, string cite)
            where X : Tag, SupportCiteAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCite(cite);
            return builder;
        }

        public static HTMLBuilder<X, Y> Colspan<X, Y>(this HTMLBuilder<X, Y> builder, int colspan)
            where X : Tag, SupportColspanAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddColspan(colspan);
            return builder;
        }

        public static HTMLBuilder<X, Y> Crossorigin<X, Y>(this HTMLBuilder<X, Y> builder, Crossorigin crossorigin)
            where X : Link
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddCrossorigin(crossorigin);
            return builder;
        }

        public static HTMLBuilder<X, Y> Datetime<X, Y>(this HTMLBuilder<X, Y> builder, DateTime datetime)
            where X : Tag, SupportDatetimeAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddDatetime(datetime);
            return builder;
        }

        public static HTMLBuilder<X, Y> Download<X, Y>(this HTMLBuilder<X, Y> builder, string filename = "")
            where X : A
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddDownload(filename);
            return builder;
        }

        public static HTMLBuilder<X, Y> Execution<X, Y>(this HTMLBuilder<X, Y> builder, Execution execution)
            where X : ExternalScript
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddExecution(execution);
            return builder;
        }

        public static HTMLBuilder<X, Y> Headers<X, Y>(this HTMLBuilder<X, Y> builder, string headers)
            where X : Tag, SupportHeadersAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHeaders(headers);
            return builder;
        }

        public static HTMLBuilder<X, Y> Height<X, Y>(this HTMLBuilder<X, Y> builder, int height)
            where X : Tag, SupportHeightAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHeight(height);
            return builder;
        }

        public static HTMLBuilder<X, Y> HttpEquiv<X, Y>(this HTMLBuilder<X, Y> builder, HttpEquiv httpEquiv, string content)
            where X : Meta
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddHttpEquiv(httpEquiv, content);
            return builder;
        }

        public static HTMLBuilder<X, Y> Media<X, Y>(this HTMLBuilder<X, Y> builder, string media)
            where X : Tag, SupportMediaQueryAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddMedia(media);
            return builder;
        }

        public static HTMLBuilder<X, Y> Name<X, Y>(this HTMLBuilder<X, Y> builder, string name)
            where X : Tag, SupportNameAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddName(name);
            return builder;
        }

        public static HTMLBuilder<X, Y> Name<X, Y>(this HTMLBuilder<X, Y> builder, Name name, string content)
            where X : Meta
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddName(name, content);
            return builder;
        }

        public static HTMLBuilder<X, Y> Open<X, Y>(this HTMLBuilder<X, Y> builder)
            where X : Details
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddOpen();
            return builder;
        }

        public static HTMLBuilder<X, Y> Rel<X, Y>(this HTMLBuilder<X, Y> builder, Rel rel)
            where X : Tag, SupportRelAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRel(rel);
            return builder;
        }

        public static HTMLBuilder<X, Y> Rel<X, Y>(this HTMLBuilder<X, Y> builder, LinkRel rel)
            where X : Link
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRel(rel);
            return builder;
        }

        public static HTMLBuilder<X, Y> Rowspan<X, Y>(this HTMLBuilder<X, Y> builder, int rowspan)
            where X : Tag, SupportRowspanAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddRowspan(rowspan);
            return builder;
        }

        public static HTMLBuilder<X, Y> Sandbox<X, Y>(this HTMLBuilder<X, Y> builder, params Sandbox[] sandbox)
            where X : Iframe
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSandbox(sandbox);
            return builder;
        }

        public static HTMLBuilder<X, Y> Span<X, Y>(this HTMLBuilder<X, Y> builder, int span)
            where X : Tag, SupportSpanAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSpan(span);
            return builder;
        }

        public static HTMLBuilder<X, Y> Src<X, Y>(this HTMLBuilder<X, Y> builder, string src)
            where X : Tag, SupportSrcAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSrc(src);
            return builder;
        }

        public static HTMLBuilder<X, Y> Srcdoc<X, Y>(this HTMLBuilder<X, Y> builder, string srcdoc)
            where X : Iframe
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddSrcdoc(srcdoc);
            return builder;
        }

        public static HTMLBuilder<X, Y> Target<X, Y>(this HTMLBuilder<X, Y> builder, Target target)
            where X : Tag, SupportTargetAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddTarget(target);
            return builder;
        }

        public static HTMLBuilder<X, Y> Type<X, Y>(this HTMLBuilder<X, Y> builder, string type)
            where X : Tag, SupportMIMETypeAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddType(type);
            return builder;
        }

        public static HTMLBuilder<X, Y> Value<X, Y>(this HTMLBuilder<X, Y> builder, int value)
            where X : Tag, SupportNumberValueAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddValue(value);
            return builder;
        }

        public static HTMLBuilder<X, Y> Width<X, Y>(this HTMLBuilder<X, Y> builder, int width)
            where X : Tag, SupportWidthAttribute
            where Y : HTMLBuilder
        {
            builder.CurrentTag.AddWidth(width);
            return builder;
        }
    }
}