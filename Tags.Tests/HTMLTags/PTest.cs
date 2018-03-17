using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class PTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new P().ToString(), "<p></p>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new P().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}