using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class VarTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Var().ToString(), "<var></var>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Var().TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}