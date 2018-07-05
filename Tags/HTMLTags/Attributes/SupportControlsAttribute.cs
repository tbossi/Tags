namespace Tags.HTMLTags.Attributes
{
    public interface SupportControlsAttribute : ITag { }

    public static class ControlsAttribute
    {
        public static void AddControls(this SupportControlsAttribute tag)
        {
            tag.TagBuilder.MergeAttribute("controls", "controls");
        }
    }
}