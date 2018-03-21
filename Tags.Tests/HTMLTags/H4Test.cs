using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class H4Test
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new H4().ToString(), "<h4></h4>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new H4().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}