using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ReadonlyAttributeTest : AttributeTest<SupportReadonlyAttribute>
    {
        [Test]
        public void AddReadonly()
        {
            AssertAttributeAdded(tag => tag.AddReadonly(), $"<test readonly=\"readonly\"></test>");
        }
    }
}