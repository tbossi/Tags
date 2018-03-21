using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SpanTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Span().ToString(), "<span></span>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Span().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}