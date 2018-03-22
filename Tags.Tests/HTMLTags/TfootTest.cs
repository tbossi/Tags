using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TfootTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Tfoot().ToString(), "<tfoot></tfoot>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Tfoot().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}