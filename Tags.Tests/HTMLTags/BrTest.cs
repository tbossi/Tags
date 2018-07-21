using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BrTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Br().ToString(), "<br>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Br().TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}