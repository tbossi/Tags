using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MaxLengthAttributeTest : AttributeTest<SupportMaxLengthAttribute>
    {
        [Test]
        public void AddMaxLength_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddMaxLength(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddMaxLength(int maxlength)
        {
            AssertAttributeAdded(tag => tag.AddMaxLength(maxlength), $"<test maxlength=\"{maxlength}\"></test>");
        }
    }
}