namespace Tags.HTMLTags.Attributes
{
    public interface SupportAutocompleteAttribute : ITag { }

    public static class AutocompleteAttribute
    {
        public static void AddAutocomplete(this SupportAutocompleteAttribute tag, bool autocomplete)
        {
            tag.AddAttribute("autocomplete", autocomplete ? "on" : "off");
        }
    }
}