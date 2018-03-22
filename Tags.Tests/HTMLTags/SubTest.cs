using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SubTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Sub().ToString(), "<sub></sub>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Sub().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}