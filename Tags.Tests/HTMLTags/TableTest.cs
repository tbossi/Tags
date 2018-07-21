using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TableTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Table().ToString(), "<table></table>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Table().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}