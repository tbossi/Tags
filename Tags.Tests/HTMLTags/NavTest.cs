using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class NavTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Nav().ToString(), "<nav></nav>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Nav().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}