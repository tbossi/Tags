using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HeadersAttributeTest : AttributeTest<SupportHeadersAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddHeaders_ThrowsException(string headers)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddHeaders(headers));
        }

        [Test]
        public void AddHeaders()
        {
            AssertAttributeAdded(tag => tag.AddHeaders("header_id"), "<test headers=\"header_id\"></test>");
        }
    }
}