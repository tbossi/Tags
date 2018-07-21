namespace Tags.HTMLTags.Attributes
{
    public interface SupportRelAttribute : ITag { }

    public static class RelAttribute
    {
        public static void AddRel(this SupportRelAttribute tag, Rel rel)
        {
            tag.AddAttribute("rel", rel.LiteralValue());
        }
    }
}