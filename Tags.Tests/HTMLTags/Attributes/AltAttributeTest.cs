using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AltAttributeTest : AttributeTest<SupportAltAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddAlt_ThrowsException(string alt)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddAlt(alt));
        }

        [Test]
        public void AddAlt()
        {
            AssertAttributeAdded(tag => tag.AddAlt("alternative"), "<test alt=\"alternative\"></test>");
        }
    }
}