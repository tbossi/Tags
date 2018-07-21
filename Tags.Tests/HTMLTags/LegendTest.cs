using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class LegendTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Legend().ToString(), "<legend></legend>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Legend().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}