using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class PictureTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Picture().ToString(), "<picture></picture>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Picture().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}