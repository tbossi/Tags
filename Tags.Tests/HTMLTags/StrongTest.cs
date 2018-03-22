using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class StrongTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Strong().ToString(), "<strong></strong>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Strong().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}