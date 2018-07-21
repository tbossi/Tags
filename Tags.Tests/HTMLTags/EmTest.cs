using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class EmTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Em().ToString(), "<em></em>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Em().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}