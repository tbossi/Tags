using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AbbrTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Abbr().ToString(), "<abbr></abbr>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Abbr().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}