using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MediaQueryAttributeTest : AttributeTest<SupportMediaQueryAttribute>
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("       ")]
        public void AddMedia_ThrowsException(string media)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddMedia(media));
        }

        [Test]
        public void AddMedia()
        {
            AssertAttributeAdded(tag => tag.AddMedia("media_query"), "<test media=\"media_query\"></test>");
        }
    }
}