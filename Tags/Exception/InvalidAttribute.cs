using Tags.HTMLTags;

namespace Tags.Exception
{
    public class InvalidAttribute : System.Exception
    {
        public InvalidAttribute(string attributeName, Tag tag)
            : base($"Cannot add {attributeName} attribute to {tag}") { }
    }
}