using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TheadTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Thead().ToString(), "<thead></thead>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Thead().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}