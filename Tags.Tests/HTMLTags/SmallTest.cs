using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SmallTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Small().ToString(), "<small></small>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Small().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}