using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TitleTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Title().ToString(), "<title></title>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Title().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}