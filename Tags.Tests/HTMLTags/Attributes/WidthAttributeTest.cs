using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class WidthAttributeTest : AttributeTest<SupportWidthAttribute>
    {
        [Test]
        public void AddWidth_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddWidth(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddWidth(int width)
        {
            AssertAttributeAdded(tag => tag.AddWidth(width), $"<test width=\"{width}\"></test>");
        }
    }
}