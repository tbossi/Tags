using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MutedAttributeTest : AttributeTest<SupportMutedAttribute>
    {
        [Test]
        public void AddMuted()
        {
            AssertAttributeAdded(tag => tag.AddMuted(), $"<test muted=\"muted\"></test>");
        }
    }
}