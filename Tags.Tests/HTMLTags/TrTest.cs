using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TrTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Tr().ToString(), "<tr></tr>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Tr().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}