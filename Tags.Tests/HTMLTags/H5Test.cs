using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class H5Test
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new H5().ToString(), "<h5></h5>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new H5().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}