using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class NumberValueAttributeTest : AttributeTest<SupportNumberValueAttribute>
    {
        [Test]
        public void AddValue_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddValue(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddValue(int value)
        {
            AssertAttributeAdded(tag => tag.AddValue(value), $"<test value=\"{value}\"></test>");
        }
    }
}