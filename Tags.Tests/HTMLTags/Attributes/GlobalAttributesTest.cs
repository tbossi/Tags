using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class GlobalAttributesTest : AttributeTest<ITag>
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddId_ThrowsException(string id)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddId(id));
        }

        [Test]
        public void AddId()
        {
            AssertAttributeAdded(tag => tag.AddId("id-to-add"), "<test id=\"id-to-add\"></test>");
        }

        [Test]
        public void AddClasses()
        {
            AssertAttributeAdded(tag => tag.AddClasses("class1", "other", null, "class1", "", "ccc"), "<test class=\"ccc other class1\"></test>");
        }

        [Test]
        public void AddClasses_MultipleCalls()
        {
            AssertAttributeAdded(tag =>
            {
                tag.AddClasses("class1", "other");
                tag.AddClasses("ccc");
            }, "<test class=\"ccc other class1\"></test>");
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddData_ThrowsException(string key)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddData(key, "value"));
        }

        [Test]
        public void AddData()
        {
            AssertAttributeAdded(tag => tag.AddData("dkey", "dvalue"), "<test data-dkey=\"dvalue\"></test>");
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("       ")]
        public void AddTitle_ThrowsException(string title)
        {
            Assert.Throws<ArgumentException>(() => Tag.Object.AddTitle(title));
        }

        [Test]
        public void AddTitle()
        {
            AssertAttributeAdded(tag => tag.AddTitle("title to add"), "<test title=\"title to add\"></test>");
        }
    }
}