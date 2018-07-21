using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DivTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Div().ToString(), "<div></div>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Div().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}