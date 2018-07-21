using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BdiTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Bdi().ToString(), "<bdi></bdi>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Bdi().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}