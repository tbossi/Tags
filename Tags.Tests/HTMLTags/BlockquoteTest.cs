using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BlockquoteTest
    {
        private readonly Blockquote tag = new Blockquote();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<blockquote></blockquote>");
        }

        [Test]
        public void AddCite()
        {
            tag.AddCite("http://something");
            Assert.AreEqual(tag.ToString(), "<blockquote cite=\"http://something\"></blockquote>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}