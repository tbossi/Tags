using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class KbdTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Kbd().ToString(), "<kbd></kbd>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Kbd().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}