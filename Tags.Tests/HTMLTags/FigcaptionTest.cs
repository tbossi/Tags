using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class FigcaptionTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Figcaption().ToString(), "<figcaption></figcaption>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Figcaption().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}