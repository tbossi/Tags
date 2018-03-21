using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HeadTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Head().ToString(), "<head></head>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Head().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}