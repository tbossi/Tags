using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SrcsetAttributeTest : AttributeTest<SupportSrcsetAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddSrcset_ThrowsException(string url)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddSrcset(url));
        }

        [Test]
        public void AddSrcset()
        {
            AssertAttributeAdded(tag => tag.AddSrcset("http://something"), "<test srcset=\"http://something\"></test>");
        }
    }
}