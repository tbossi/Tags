using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CanvasTest
    {
        private readonly Canvas tag = new Canvas();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<canvas></canvas>");
        }

        [Test]
        public void AddHeight()
        {
            tag.AddHeight(500);
            Assert.AreEqual(tag.ToString(), "<canvas height=\"500\"></canvas>");
        }

        [Test]
        public void AddWidth()
        {
            tag.AddWidth(987);
            Assert.AreEqual(tag.ToString(), "<canvas width=\"987\"></canvas>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}