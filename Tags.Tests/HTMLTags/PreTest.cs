using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class PreTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Pre().ToString(), "<pre></pre>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Pre().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}