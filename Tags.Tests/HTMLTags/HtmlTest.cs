using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HtmlTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Html().ToString(), "<html></html>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Html().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}