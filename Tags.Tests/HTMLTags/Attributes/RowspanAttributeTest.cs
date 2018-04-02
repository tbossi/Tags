using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class RowspanAttributeTest : AttributeTest<SupportRowspanAttribute>
    {
        [Test]
        public void AddRowspan_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddRowspan(-20));
        }

        [TestCase(0)]
        [TestCase(35)]
        public void AddRowspan(int value)
        {
            AssertAttributeAdded(tag => tag.AddRowspan(value), $"<test rowspan=\"{value}\"></test>");
        }
    }
}