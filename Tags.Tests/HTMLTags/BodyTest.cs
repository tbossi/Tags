using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BodyTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Body().ToString(), "<body></body>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Body().TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}