using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MultipleAttributeTest : AttributeTest<SupportMultipleAttribute>
    {
        [Test]
        public void AddMultiple()
        {
            AssertAttributeAdded(tag => tag.AddMultiple(), $"<test multiple=\"multiple\"></test>");
        }
    }
}