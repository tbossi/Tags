using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class StringValueAttributeTest : AttributeTest<SupportStringValueAttribute>
    {
        [TestCase("")]
        [TestCase("some value")]
        public void AddValue(string value)
        {
            AssertAttributeAdded(tag => tag.AddValue(value), $"<test value=\"{value}\"></test>");
        }
    }
}