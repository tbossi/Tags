using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class FooterTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Footer().ToString(), "<footer></footer>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Footer().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}