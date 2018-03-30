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
        public void StoreTag()
        {
            var tagToStore = new Mock<Tag>("test");
            var newBuilder = _htmlTag.StoreTag(tagToStore.Object);

            Assert.AreEqual(newBuilder.CurrentTag, tagToStore.Object);
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
                t => t.AddInnerHtml(innerTag1.Object, innerTag2.Object));
        }

        [Test]
        public void InnerText()
        {
            const string textToAdd = "text to add";

            CommonAssert(builder => builder.InnerText(textToAdd),
                t => t.AddInnerHtml(new HTMLTags.Text(textToAdd)));
        }

        [Test]
        public void Class()
        {
            const string class1 = "class1";
            const string class2 = "class2";
            const string class3 = "class3";

            CommonAssert(builder => builder.Class(class1, class2, class3),
                t => t.AddClasses(class1, class2, class3));
        }

        [Test]
        public void Id()
        {
            const string id = "id";

            CommonAssert(builder => builder.Id(id), t => t.AddId(id));
        }

        [Test]
        public void Data()
        {
            const string key = "key";
            const string value = "value";

            CommonAssert(builder => builder.Data(key, value), t => t.AddData(key, value));
        }

        [Test]
        public void Title()
        {
            const string title = "title";

            CommonAssert(builder => builder.Title(title), t => t.AddTitle(title));
        }

        private void CommonAssert(Func<HTMLBuilder<Tag, HTMLBuilder>, HTMLBuilder<Tag, HTMLBuilder>> actionToTest, Expression<Action<HTMLTags.Tag>> actionToVerify)
        {
            var tag = new Mock<HTMLTags.Tag>("tagForTest");

            tag.Setup(actionToVerify).Verifiable();

            _htmlTag.StoreTag(tag.Object);
            var actualHtmlTag = actionToTest.Invoke(_htmlTag);
            Assert.AreEqual(actualHtmlTag, _htmlTag);

            tag.VerifyAll();
        }
    }
}