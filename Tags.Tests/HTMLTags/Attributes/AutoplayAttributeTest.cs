using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AutoplayAttributeTest : AttributeTest<SupportAutoplayAttribute>
    {
        [Test]
        public void AddAutoplay()
        {
            AssertAttributeAdded(tag => tag.AddAutoplay(), $"<test autoplay=\"autoplay\"></test>");
        }
    }
}