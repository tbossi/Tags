using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ArticleTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Article().ToString(), "<article></article>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Article().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}