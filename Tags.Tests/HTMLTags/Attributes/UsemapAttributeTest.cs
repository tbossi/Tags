using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class UsemapAttributeTest : AttributeTest<SupportUsemapAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddUsemap_ThrowsException(string id)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddUsemap(id));
        }

        [Test]
        public void AddUsemap()
        {
            AssertAttributeAdded(tag => tag.AddUsemap("#map-id"), "<test usemap=\"#map-id\"></test>");
        }
    }
}