using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DfnTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Dfn().ToString(), "<dfn></dfn>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Dfn().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}