using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class H2Test
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new H2().ToString(), "<h2></h2>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new H2().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}