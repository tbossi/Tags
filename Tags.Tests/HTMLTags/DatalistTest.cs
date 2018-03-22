using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DatalistTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Datalist().ToString(), "<datalist></datalist>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Datalist().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}