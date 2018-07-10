using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class RequiredAttributeTest : AttributeTest<SupportRequiredAttribute>
    {
        [Test]
        public void AddRequired()
        {
            AssertAttributeAdded(tag => tag.AddRequired(), $"<test required=\"required\"></test>");
        }
    }
}