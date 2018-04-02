using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ColspanAttributeTest : AttributeTest<SupportColspanAttribute>
    {
        [Test]
        public void AddColspan_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddColspan(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddColspan(int value)
        {
            AssertAttributeAdded(tag => tag.AddColspan(value), $"<test colspan=\"{value}\"></test>");
        }
    }
}