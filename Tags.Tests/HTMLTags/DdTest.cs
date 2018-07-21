using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DdTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Dd().ToString(), "<dd></dd>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Dd().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}