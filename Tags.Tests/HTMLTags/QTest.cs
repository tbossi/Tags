using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class QTest
    {
        private readonly Q tag = new Q();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<q></q>");
        }

        [Test]
        public void AddCite()
        {
            tag.AddCite("http://something");
            Assert.AreEqual(tag.ToString(), "<q cite=\"http://something\"></q>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}