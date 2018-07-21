using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new B().ToString(), "<b></b>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new B().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}