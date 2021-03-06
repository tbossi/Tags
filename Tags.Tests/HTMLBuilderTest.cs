using System;
using System.Linq.Expressions;
using Moq;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using static Tags.HTMLBuilder;

namespace Tags.Test
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HTMLBuilderTest
    {
        private HTMLBuilder<Tag, HTMLBuilder> _htmlTag;

        [SetUp]
        public void SetUp()
        {
            _htmlTag = HTMLBuilder.Tag;
        }

        [Test]
        public void Tags()
        {
            var tag2 = HTMLBuilder.Tag;
            Assert.AreNotEqual(_htmlTag, tag2);
        }

        [Test]
        public void StoreTag_NoParent()
        {
            var tagToStore = new Mock<Tag>("test");
            var newBuilder = _htmlTag.StoreTag(tagToStore.Object);
            
            Assert.AreEqual(newBuilder.CurrentTag, tagToStore.Object);
        }

        [Test]
        public void StoreTag()
        {
            var tagToStore = new TestTag("test");
            var tagToStore2 = new TestTag("test");
            var newBuilder = _htmlTag.StoreTag(tagToStore);
            var lastBuilder = newBuilder.StoreTag(tagToStore2);
            
            Assert.AreEqual(newBuilder.CurrentTag, tagToStore);
            Assert.AreEqual(newBuilder.CurrentTag.Content[0], tagToStore2);
        }

        [Test]
        public void End_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => _htmlTag.End());
        }

        [Test]
        public void End()
        {
            var tagToStore = new Mock<Tag>("test");
            var newBuilder = _htmlTag.StoreTag(tagToStore.Object);

            Assert.AreEqual(_htmlTag, newBuilder.End());
        }

        [Test]
        public void EndAll()
        {
            Assert.Fail();
            //TODO
        }

        [Test]
        public void InnerHTML()
        {
            var innerTag1 = new Mock<HTMLTags.Tag>("innerTag1");
            var innerTag2 = new Mock<HTMLTags.Tag>("innerTag2");

            CommonAssert(builder => builder.InnerHTML(innerTag1.Object, innerTag2.Object),
                $"<test>{innerTag1.Object.ToString()}{innerTag2.Object.ToString()}</test>");
        }

        [Test]
        public void InnerText()
        {
            const string textToAdd = "text to add";

            CommonAssert(builder => builder.InnerText(textToAdd), $"<test>{textToAdd}</test>");
        }

        [Test]
        public void Class()
        {
            const string class1 = "class1";
            const string class2 = "class2";
            const string class3 = "class3";

            CommonAssert(builder => builder.Class(class1, class2, class3),
                $"<test class=\"{class1} {class2} {class3}\"></test>");
        }

        [Test]
        public void Id()
        {
            const string id = "id";

            CommonAssert(builder => builder.Id(id), $"<test id=\"{id}\"></test>");
        }

        [Test]
        public void Data()
        {
            const string key = "key";
            const string value = "value";

            CommonAssert(builder => builder.Data(key, value), $"<test data-{key}=\"{value}\"></test>");
        }

        [Test]
        public void Title()
        {
            const string title = "title";

            CommonAssert(builder => builder.Title(title), $"<test title=\"{title}\"></test>");
        }

        private void CommonAssert(Func<HTMLBuilder<Tag, HTMLBuilder<Tag, HTMLBuilder>>, HTMLBuilder<Tag, HTMLBuilder<Tag, HTMLBuilder>>> actionToTest, string expectedResult)
        {
            var tag = (Tag) new TestTag("test");

            var builder = _htmlTag.StoreTag(tag);
            var actualHtmlTag = actionToTest.Invoke(builder);
            Assert.AreEqual(builder, actualHtmlTag);
            Assert.AreEqual(expectedResult, actualHtmlTag.End().ToString());
        }
    }
}