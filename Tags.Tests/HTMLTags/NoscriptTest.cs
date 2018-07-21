using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class NoscriptTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Noscript().ToString(), "<noscript></noscript>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Noscript().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}