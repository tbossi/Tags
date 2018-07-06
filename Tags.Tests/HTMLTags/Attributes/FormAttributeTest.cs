using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class FormAttributeTest : AttributeTest<SupportFormAttribute>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddForm_ThrowsException(string id)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddForm(id));
        }

        [Test]
        public void AddForm()
        {
            AssertAttributeAdded(tag => tag.AddForm("form_id"), "<test form=\"form_id\"></test>");
        }
    }
}