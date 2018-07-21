using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ITest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new I().ToString(), "<i></i>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new I().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}