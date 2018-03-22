using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class RtTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Rt().ToString(), "<rt></rt>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Rt().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}