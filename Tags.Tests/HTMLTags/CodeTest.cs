using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CodeTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Code().ToString(), "<code></code>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Code().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}