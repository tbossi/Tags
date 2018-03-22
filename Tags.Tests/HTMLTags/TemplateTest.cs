using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TemplateTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Template().ToString(), "<template></template>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Template().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}