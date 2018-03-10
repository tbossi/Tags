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
        public static HTMLBuilder Div(this HTMLBuilder builder) => AddTagIfAllowed(builder, new Div());
        public static HTMLBuilder P(this HTMLBuilder builder) => AddTagIfAllowed(builder, new P());
    }

    public static class HTMLBuilderAttributes
    {
        public static HTMLBuilder Download(this HTMLBuilder builder, string filename = "")
        {
            if (builder.CurrentOpenTag is A)
            {
                (builder.CurrentOpenTag as A).AddDownload(filename);
                return builder;
            }

            throw new InvalidAttribute("download", builder.CurrentOpenTag);
        }

        public static HTMLBuilder Rel(this HTMLBuilder builder, Rel rel)
        {
            if (builder.CurrentOpenTag is A)
            {
                (builder.CurrentOpenTag as A).AddRel(rel);
                return builder;
            }

            throw new InvalidAttribute("rel", builder.CurrentOpenTag);
        }

        public static HTMLBuilder Target(this HTMLBuilder builder, Target target)
        {
            if (builder.CurrentOpenTag is A)
            {
                (builder.CurrentOpenTag as A).AddTarget(target);
                return builder;
            }

            throw new InvalidAttribute("target", builder.CurrentOpenTag);
        }
    }
}