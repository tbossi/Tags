using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DlTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Dl().ToString(), "<dl></dl>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Dl().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}