using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class LiTest
    {
        private readonly Li tag = new Li();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<li></li>");
        }

        [Test]
        public void AddValue()
        {
            tag.AddValue(5);
            Assert.AreEqual(tag.ToString(), "<li value=\"5\"></li>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}