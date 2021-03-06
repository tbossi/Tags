using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SampTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Samp().ToString(), "<samp></samp>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Samp().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}