using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SummaryTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Summary().ToString(), "<summary></summary>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Summary().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}