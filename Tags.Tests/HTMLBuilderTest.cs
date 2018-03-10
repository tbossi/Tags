using System;
using System.Linq.Expressions;
using Moq;
using NUnit.Framework;
using static Tags.HTMLBuilder;

namespace Tags.Test
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HTMLBuilderTest
    {
        private HTMLBuilder _htmlTag;

        [SetUp]
        public void SetUp()
        {
            _htmlTag = Tag;
        }

        [Test]
        public void Tags()
        {
            var tag2 = Tag;
            Assert.AreNotEqual(_htmlTag, tag2);
        }

        [Test]
        public void CurrentOpenTag()
        {
            var tag = new Mock<HTMLTags.Tag>("tagfortest");

            Assert.Null(_htmlTag.CurrentOpenTag);
            _htmlTag.StoreTag(tag.Object);
            Assert.AreEqual(_htmlTag.CurrentOpenTag, tag.Object);
        }

        [Test]
        public void End()
        {
            Assert.Null(_htmlTag.CurrentOpenTag);
            _htmlTag.StoreTag(null);
            var actualHtmlTag = _htmlTag.End();

            Assert.AreEqual(actualHtmlTag, _htmlTag);
            Assert.Null(_htmlTag.CurrentOpenTag);
        }

        [Test]
        public void EndAll()
        {
            var outerTag = new Mock<HTMLTags.Tag>("outerTag");
            var innerTag = new Mock<HTMLTags.Tag>("innerTag");

            Assert.Null(_htmlTag.CurrentOpenTag);

            outerTag.Setup(t => t.AddInnerHtml(innerTag.Object)).Verifiable();
            innerTag.Setup(t => t.AddInnerHtml(It.IsAny<HTMLTags.Tag>())).Verifiable();

            _htmlTag.StoreTag(outerTag.Object);
            _htmlTag.StoreTag(innerTag.Object);
            _htmlTag.StoreTag(null);
            var actualHtmlTag = _htmlTag.EndAll();

            Assert.AreEqual(actualHtmlTag, _htmlTag);
            Assert.Null(_htmlTag.CurrentOpenTag);

            outerTag.VerifyAll();
            innerTag.VerifyAll();
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

        private void CommonAssert(Func<HTMLBuilder, HTMLBuilder> actionToTest, Expression<Action<HTMLTags.Tag>> actionToVerify)
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