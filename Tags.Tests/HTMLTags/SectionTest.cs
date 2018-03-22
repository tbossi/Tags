using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SectionTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Section().ToString(), "<section></section>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Section().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}