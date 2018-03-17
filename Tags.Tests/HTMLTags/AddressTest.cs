using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AddressTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Address().ToString(), "<address></address>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Address().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}