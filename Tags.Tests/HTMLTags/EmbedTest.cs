using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class EmbedTest
    {
        private readonly Embed tag = new Embed("http://src");

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<embed src=\"http://src\">");
        }

        [Test]
        public void AddHeight()
        {
            tag.AddHeight(500);
            Assert.AreEqual(tag.ToString(), "<embed src=\"http://src\" height=\"500\">");
        }

        [Test]
        public void AddWidth()
        {
            tag.AddWidth(987);
            Assert.AreEqual(tag.ToString(), "<embed src=\"http://src\" width=\"987\">");
        }

        [Test]
        public void AddType()
        {
            tag.AddType("mime/type");
            Assert.AreEqual(tag.ToString(), "<embed src=\"http://src\" type=\"mime/type\">");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.StartTag);
        }
    }
}