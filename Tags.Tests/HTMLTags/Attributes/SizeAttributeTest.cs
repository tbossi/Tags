using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SizeAttributeTest : AttributeTest<SupportSizeAttribute>
    {
        [Test]
        public void AddSize_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddSize(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddSize(int value)
        {
            AssertAttributeAdded(tag => tag.AddSize(value), $"<test size=\"{value}\"></test>");
        }
    }
}