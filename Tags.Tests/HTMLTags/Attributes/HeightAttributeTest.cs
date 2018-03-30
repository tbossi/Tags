using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HeightAttributeTest : AttributeTest<SupportHeightAttribute>
    {
        [Test]
        public void AddHeight_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddHeight(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddHeight(int height)
        {
            AssertAttributeAdded(tag => tag.AddHeight(height), $"<test height=\"{height}\"></test>");
        }
    }
}