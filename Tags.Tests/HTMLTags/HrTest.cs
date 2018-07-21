using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class HrTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Hr().ToString(), "<hr>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Hr().TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}