using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CiteAttributeTest : AttributeTest<SupportCiteAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddCite_ThrowsException(string cite)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddCite(cite));
        }

        [Test]
        public void AddCite()
        {
            AssertAttributeAdded(tag => tag.AddCite("http://something"), "<test cite=\"http://something\"></test>");
        }
    }
}