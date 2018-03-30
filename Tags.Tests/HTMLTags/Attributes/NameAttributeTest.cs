using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class NameAttributeTest : AttributeTest<SupportNameAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddName_ThrowsException(string name)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddName(name));
        }

        [Test]
        public void AddName()
        {
            AssertAttributeAdded(tag => tag.AddName("nameasd"), "<test name=\"nameasd\"></test>");
        }
    }
}