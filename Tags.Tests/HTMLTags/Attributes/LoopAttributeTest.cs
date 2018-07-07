using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class LoopAttributeTest : AttributeTest<SupportLoopAttribute>
    {
        [Test]
        public void AddLoop()
        {
            AssertAttributeAdded(tag => tag.AddLoop(), $"<test loop=\"loop\"></test>");
        }
    }
}