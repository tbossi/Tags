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
                builder.StoreTag(tagToAdd);
                return builder;
            }

            builder.StoreTag(tagToAdd);
            return builder;
            //throw new ArgumentException($"Cannot place {tagToAdd} inside {builder.CurrentOpenTag}");
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
        public static HTMLBuilder Blockquote(this HTMLBuilder builder, string cite = "") => AddTagIfAllowed(builder, new Blockquote(cite));
        public static HTMLBuilder Body(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Body());
        public static HTMLBuilder Br(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Br());
        public static HTMLBuilder Div(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Div());
        public static HTMLBuilder H1(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H1());
        public static HTMLBuilder H2(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H2());
        public static HTMLBuilder H3(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H3());
        public static HTMLBuilder H4(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H4());
        public static HTMLBuilder H5(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H5());
        public static HTMLBuilder H6(this HTMLBuilder builder) => AddTagIfAllowed(builder, new H6());
        public static HTMLBuilder Head(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Head());
        public static HTMLBuilder I(this HTMLBuilder builder) => AddTagIfAllowed(builder, new I());
        public static HTMLBuilder Legend(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Legend());
        public static HTMLBuilder Mark(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Mark());
        public static HTMLBuilder Noscript(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Noscript());
        public static HTMLBuilder P(this HTMLBuilder builder) => AddTagIfAllowed(builder, new P());
        public static HTMLBuilder Pre(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Pre());
        public static HTMLBuilder Span(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Span());
        public static HTMLBuilder Table(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Table());
        public static HTMLBuilder Title(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Title());
    }

    public static class HTMLBuilderAttributes
    {
        public static HTMLBuilder Download(this HTMLBuilder builder, string filename = "")
        {
            if (builder.CurrentOpenTag is A tag)
            {
                tag.AddDownload(filename);
                return builder;
            }

            throw new InvalidAttribute("download", builder.CurrentOpenTag);
        }

        public static HTMLBuilder Rel(this HTMLBuilder builder, Rel rel)
        {
            if (builder.CurrentOpenTag is IRelable tag)
            {
                tag.AddRel(rel);
                return builder;
            }

            throw new InvalidAttribute("rel", builder.CurrentOpenTag);
        }

        public static HTMLBuilder Target(this HTMLBuilder builder, Target target)
        {
            if (builder.CurrentOpenTag is ITargetable tag)
            {
                tag.AddTarget(target);
                return builder;
            }

            throw new InvalidAttribute("target", builder.CurrentOpenTag);
        }
    }
}