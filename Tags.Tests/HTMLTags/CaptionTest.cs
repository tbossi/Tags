using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CaptionTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Caption().ToString(), "<caption></caption>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Caption().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}