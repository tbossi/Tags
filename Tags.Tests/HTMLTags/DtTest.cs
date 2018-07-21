using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DtTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Dt().ToString(), "<dt></dt>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Dt().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}