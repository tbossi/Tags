using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MarkTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Mark().ToString(), "<mark></mark>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Mark().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}