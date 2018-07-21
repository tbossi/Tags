using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DetailsTest
    {
        private Details _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Details();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), $"<details></details>");
        }

        [Test]
        public void AddOpen()
        {
            _tag.AddOpen();
            Assert.AreEqual(_tag.ToString(), "<details open=\"open\"></details>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}