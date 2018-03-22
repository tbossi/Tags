using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class RpTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Rp().ToString(), "<rp></rp>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Rp().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}