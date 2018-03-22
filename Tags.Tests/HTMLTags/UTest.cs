using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class UTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new U().ToString(), "<u></u>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new U().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}