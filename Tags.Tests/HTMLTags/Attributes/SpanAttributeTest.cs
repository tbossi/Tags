using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SpanAttributeTest : AttributeTest<SupportSpanAttribute>
    {
        [Test]
        public void AddSpan_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddSpan(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddSpan(int span)
        {
            AssertAttributeAdded(tag => tag.AddSpan(span), $"<test span=\"{span}\"></test>");
        }
    }
}