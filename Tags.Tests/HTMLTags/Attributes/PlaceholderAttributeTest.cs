using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class PlaceholderAttributeTest : AttributeTest<SupportPlaceholderAttribute>
    {
        [Test]
        public void AddPlaceholder()
        {
            AssertAttributeAdded(tag => tag.AddPlaceholder("some placeholder text"), "<test placeholder=\"some placeholder text\"></test>");
        }
    }
}