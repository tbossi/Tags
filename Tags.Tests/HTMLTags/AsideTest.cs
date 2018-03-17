using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AsideTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Aside().ToString(), "<aside></aside>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Aside().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}