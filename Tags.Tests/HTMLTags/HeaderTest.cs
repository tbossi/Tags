using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HeaderTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Header().ToString(), "<header></header>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Header().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}