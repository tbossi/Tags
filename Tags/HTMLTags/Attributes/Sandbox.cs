namespace Tags.HTMLTags.Attributes
{
    public sealed class Sandbox
    {
        public readonly string Value;
        private Sandbox(string value)
        {
            Value = value;
        }

        public static Sandbox ApplyAll => new Sandbox("");
        public static Sandbox AllowForms => new Sandbox("allow-forms");
        public static Sandbox AllowPointerLock => new Sandbox("allow-pointer-lock");
        public static Sandbox AllowPopups => new Sandbox("allow-popups");
        public static Sandbox AllowSameOrigin => new Sandbox("allow-same-origin");
        public static Sandbox AllowScripts => new Sandbox("allow-scripts");
        public static Sandbox AllowTopNavigation => new Sandbox("allow-top-navigation");
    }
}