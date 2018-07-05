using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DisabledAttributeTest : AttributeTest<SupportDisabledAttribute>
    {
        [Test]
        public void AddDisabled()
        {
            AssertAttributeAdded(tag => tag.AddDisabled(), $"<test disabled=\"disabled\"></test>");
        }
    }
}