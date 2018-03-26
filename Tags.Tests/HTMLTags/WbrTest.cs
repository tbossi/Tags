using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class WbrTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Wbr().ToString(), "<wbr>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Wbr().TagRenderMode, System.Web.Mvc.TagRenderMode.StartTag);
        }
    }
}