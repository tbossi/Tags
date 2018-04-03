using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CharsetAttributeTest : AttributeTest<SupportCharsetAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddCharset_ThrowsException(string charset)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddCharset(charset));
        }

        [Test]
        public void AddCharset()
        {
            AssertAttributeAdded(tag => tag.AddCharset("UTF-8"), "<test charset=\"UTF-8\"></test>");
        }
    }
}