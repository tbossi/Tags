using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ForAttributeTest : AttributeTest<SupportForAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddFor_ThrowsException(string id)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddFor(id));
        }

        [Test]
        public void AddFor()
        {
            AssertAttributeAdded(tag => tag.AddFor("some_element_id"), "<test for=\"some_element_id\"></test>");
        }
    }
}