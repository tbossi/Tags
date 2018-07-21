using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class H6Test
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new H6().ToString(), "<h6></h6>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new H6().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}