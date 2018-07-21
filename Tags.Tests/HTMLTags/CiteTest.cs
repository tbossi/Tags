using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CiteTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Cite().ToString(), "<cite></cite>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Cite().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}