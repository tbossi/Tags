using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TbodyTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Tbody().ToString(), "<tbody></tbody>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Tbody().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}