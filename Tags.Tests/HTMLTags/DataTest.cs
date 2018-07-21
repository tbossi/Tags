using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DataTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Data("123 as-#").ToString(), "<data value=\"123 as-#\"></data>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Data("").TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}