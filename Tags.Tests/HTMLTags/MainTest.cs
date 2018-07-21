using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MainTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Main().ToString(), "<main></main>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Main().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}