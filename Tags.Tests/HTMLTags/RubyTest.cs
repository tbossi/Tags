using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class RubyTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Ruby().ToString(), "<ruby></ruby>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Ruby().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}