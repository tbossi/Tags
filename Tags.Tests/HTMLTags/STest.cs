using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class STest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new S().ToString(), "<s></s>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new S().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}