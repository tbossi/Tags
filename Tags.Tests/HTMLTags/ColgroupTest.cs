using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ColgroupTest
    {
        private readonly Colgroup tag = new Colgroup();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<colgroup></colgroup>");
        }

        [Test]
        public void AddSpan()
        {
            tag.AddSpan(3);
            Assert.AreEqual(tag.ToString(), "<colgroup span=\"3\"></colgroup>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}