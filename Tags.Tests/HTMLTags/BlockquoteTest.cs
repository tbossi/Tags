using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BlockquoteTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Blockquote().ToString(), "<blockquote></blockquote>");
            Assert.AreEqual(new Blockquote("http://something").ToString(), "<blockquote cite=\"http://something\"></blockquote>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Blockquote().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}