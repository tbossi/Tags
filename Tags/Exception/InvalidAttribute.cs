using Tags.HTMLTags;

namespace Tags.Exception
{
    public class InvalidAttribute : System.Exception
    {
        public InvalidAttribute(string attributeName, Tag tag)
            : base(ExceptionMessages.InvalidAttributeForTag(attributeName, tag.TagName)) { }
    }
}