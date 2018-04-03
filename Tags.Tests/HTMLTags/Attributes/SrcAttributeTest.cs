using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SrcAttributeTest : AttributeTest<SupportSrcAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddSrc_ThrowsException(string cite)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddSrc(cite));
        }

        [Test]
        public void AddSrc()
        {
            AssertAttributeAdded(tag => tag.AddSrc("http://something"), "<test src=\"http://something\"></test>");
        }
    }
}