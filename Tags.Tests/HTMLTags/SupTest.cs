using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SupTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Sup().ToString(), "<sup></sup>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Sup().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}