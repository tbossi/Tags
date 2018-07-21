using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class H3Test
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new H3().ToString(), "<h3></h3>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new H3().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}