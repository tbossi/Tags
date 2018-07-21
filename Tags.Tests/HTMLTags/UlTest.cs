using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class UlTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Ul().ToString(), "<ul></ul>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Ul().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}