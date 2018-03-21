using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class H1Test
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new H1().ToString(), "<h1></h1>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new H1().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}