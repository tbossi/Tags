using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MIMETypeAttributeTest : AttributeTest<SupportMIMETypeAttribute>
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("       ")]
        public void AddType_ThrowsException(string type)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddType(type));
        }

        [Test]
        public void AddType()
        {
            AssertAttributeAdded(tag => tag.AddType("mime/type"), "<test type=\"mime/type\"></test>");
        }
    }
}